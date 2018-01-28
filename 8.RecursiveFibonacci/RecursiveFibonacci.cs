using System;
using System.Collections.Generic;

class RecursiveFibonacci
{
    static void Main()
    {
        var requiredFubonacciNumber = int.Parse(Console.ReadLine());
        var temp = new long[] { 1, 1 };

        if (requiredFubonacciNumber <= 2)
        {
            Console.WriteLine(temp[requiredFubonacciNumber - 1]);
            return;
        }

        var sequence = new Queue<long>(temp);
        long third = 0;

        for (int i = 2; i < requiredFubonacciNumber; i++)
        {
            var first = sequence.Dequeue();
            var second = sequence.Peek();

            third = first + second;

            sequence.Enqueue(third);
        }
        Console.WriteLine(third);
    }
}