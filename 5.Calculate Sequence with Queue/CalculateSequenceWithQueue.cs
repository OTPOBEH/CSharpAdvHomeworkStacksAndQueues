using System;
using System.Collections.Generic;
using System.Linq;

class CalculateSequenceWithQueue
{
    static void Main()
    {
        var current = int.Parse(Console.ReadLine());
        var counter = 1;
        var sequence = new Queue<int>();
        var currentTemp = 0;

        sequence.Enqueue(current);
        Console.Write(current + " ");

        while (counter != 50)
        {
            switch (counter % 4)
            {
                case 1:

                    Console.Write(sequence.Sum() + " ");
                    break;
                case 2:
                    
                    Console.Write(sequence.Sum() + " ");
                    break;
                case 3:
;
                    Console.Write(sequence.Sum() + " ");
                    break;
                case 0:
 
                    break;
            }
            counter++;
        }
    }
}