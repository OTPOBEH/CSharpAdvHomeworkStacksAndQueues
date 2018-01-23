using System;
using System.Collections.Generic;
using System.Linq;

class BasicStackOperations
{
    static void Main()
    {
        var inputLine1    = Console.ReadLine()?.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var numbersToPush = inputLine1[0];
        var numbersToPop  = inputLine1[1];
        var quieryNumber  = inputLine1[2];

        var inputLine2 = Console.ReadLine()?.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var numbers = new Stack<int>();

        for (int i = 0; i < numbersToPush; i++)
        {
            numbers.Push(inputLine2[i]);
        }

        for (int i = 0; i < numbersToPop; i++)
        {
            numbers.Pop();
        }
        Console.WriteLine(numbers.Count == 0 ? "0" : numbers.Contains(quieryNumber) ? "true" : $"{numbers.Min()}");
    }
}