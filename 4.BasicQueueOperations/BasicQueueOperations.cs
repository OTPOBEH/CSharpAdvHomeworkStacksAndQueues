using System;
using System.Collections.Generic;
using System.Linq;

class BasicQueueOperations
{
    static void Main()
    {
        var input = Console.ReadLine()?.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        var queueLength = input[0];
        var dequeueAmount = input[1];
        var quieryNumer = input[2];
        var minNumber = int.MaxValue;

        var numbers = new Queue<int>();
        var minNumbers = new Queue<int>();
        var numbersHash = new HashSet<int>();

        var queueInput = Console.ReadLine()?.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        for (int i = 0; i < queueLength; i++)
        {
            numbers.Enqueue(queueInput[i]);
            numbersHash.Add(queueInput[i]);

            if (queueInput[i] < minNumber)
            {
                minNumber = queueInput[i];
                minNumbers.Enqueue(minNumber);
            }

            if (i >= dequeueAmount) continue;

            var removedNumber = numbers.Dequeue();
            numbersHash.Remove(removedNumber);

            if (removedNumber == minNumber)
            {
                minNumbers.Dequeue();
                minNumber = minNumbers.Count != 0 ? minNumbers.First() : int.MaxValue;
            }
        }

        if (numbersHash.Contains(quieryNumer)) Console.WriteLine("true");
        else if (numbers.Count == 0) Console.WriteLine(0);
        else Console.WriteLine(minNumber);
    }
}