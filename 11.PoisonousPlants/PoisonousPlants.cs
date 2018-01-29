using System;
using System.Collections.Generic;
using System.Linq;

public class PoisonousPlants
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var flowerField = Console.ReadLine()?
            .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var days = new int[n];
        var indexes = new Stack<int>();
        indexes.Push(0);

        for (int i = 1; i < flowerField?.Length; i++)
        {
            var maxDays = 0;

            while (indexes.Count > 0 && flowerField[indexes.Peek()] >= flowerField[i])
            {
                maxDays = Math.Max(maxDays, days[indexes.Pop()]);
            }

            if (indexes.Count > 0)
            {
                days[i] = maxDays + 1;
            }

            indexes.Push(i);
        }

        Console.WriteLine(days.Max());
    }
}
