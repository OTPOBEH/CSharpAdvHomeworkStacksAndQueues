using System;
using System.Collections.Generic;
using System.Linq;

class TruckTour
{
    static void Main()
    {
        var pumpsTotal = int.Parse(Console.ReadLine());
        var fuelData   = new Queue<int>();
        var startIndex = 0;

        for (int i = 0; i < pumpsTotal; i++)
        {
            var input     = Console.ReadLine()?.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var fuel      = input[0];
            var distance  = input[1];
            var fuelSpent = fuel - distance;
            fuelData.Enqueue(fuelSpent);
        }

        while (true)
        {
            var fuelInTank = 0;
            for (int i = 0; fuelInTank >= 0; i++)
            {
                fuelInTank += fuelData.ElementAt(i);
                if (i == pumpsTotal - 1)
                {
                    Console.WriteLine(startIndex);
                    return;
                }
            }

            var currentPump = fuelData.Dequeue();
            fuelData.Enqueue(currentPump);
            startIndex++;
        }
    }
}