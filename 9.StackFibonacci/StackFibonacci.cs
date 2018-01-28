using System;
using System.Collections.Generic;

class StackFibonacci
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

        var sequence = new Stack<long>(temp);

        for (int i = 2; i < requiredFubonacciNumber; i++)
        {
            var second = sequence.Pop();
            var first = sequence.Peek();

            var third = first + second;
            sequence.Push(second);
            sequence.Push(third);
        }
        Console.WriteLine(sequence.Peek());
    }
}