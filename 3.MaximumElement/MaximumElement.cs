using System;
using System.Collections.Generic;
using System.Linq;

class MaximumElement
{
    static void Main()
    {
        var queries = int.Parse(Console.ReadLine());
        var numbers = new Stack<int>();
        var maxNumbers = new Stack<int>();
        var maxNumber = int.MinValue;

        for (int i = 0; i < queries; i++)
        {
            var input = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            switch (input[0])
            {
                case 1:
                    numbers.Push(input[1]);
                    if (input[1] > maxNumber)
                    {
                        maxNumber = input[1];
                        maxNumbers.Push(maxNumber);
                    }
                    break;
                case 2:
                    var removedValue = numbers.Pop();
                    if (removedValue == maxNumber)
                    {
                        maxNumbers.Pop();
                        if (maxNumbers.Count != 0)
                        {
                            maxNumber = maxNumbers.Peek();
                        }
                        else
                        {
                            maxNumber = int.MinValue;
                        }
                    }

                    break;
                case 3:
                    Console.WriteLine(maxNumbers.Peek());
                    break;
            }
        }
    }
}