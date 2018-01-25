using System;
using System.Collections.Generic;
using System.Linq;

class CalculateSequenceWithQueue
{
    static void Main()
    {
        var current = long.Parse(Console.ReadLine());
        var counter = 1;
        var sequence = new Queue<long>();
        var sumCollection = new Queue<long>();
        Console.Write(current + " ");

        while (counter != 50)
        {
            switch (counter % 3)
            {
                case 1:
                    sequence.Enqueue(current);
                    sequence.Enqueue(1);
                    Console.Write(sequence.Sum() + " ");
                    sumCollection.Enqueue(sequence.Sum());
                    break;
                case 2:
                    sequence.Enqueue(current);
                    Console.Write(sequence.Sum() + " ");
                    sumCollection.Enqueue(sequence.Sum());
                    break;
                case 0:
                    sequence.Dequeue();
                    sequence.Enqueue(1);
                    Console.Write(sequence.Sum() + " ");
                    sumCollection.Enqueue(sequence.Sum());
                    sequence.Clear();
                    current = sumCollection.Dequeue();
                    break;
            }
            counter++;
        }
        Console.WriteLine();
    }
}