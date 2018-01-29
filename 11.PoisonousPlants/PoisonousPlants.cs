using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PoisonousPlants
{
    static void Main()
    {
        var flowers = int.Parse(Console.ReadLine());
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var flowerField1 = new Queue<int>(input);

        Console.WriteLine();
        var initialCount = 0;
        var days = 0;

        while (initialCount != flowerField1.Count)
        {
            initialCount = flowerField1.Count;
            var previousFlower = flowerField1.Dequeue();
            flowerField1.Enqueue(previousFlower);

            for (int i = 0; i < initialCount; i++)
            {
                var currentFlower = flowerField1.Dequeue();
                if (previousFlower < currentFlower)
                {
                    flowerField1.Enqueue(currentFlower);
                }
                previousFlower = currentFlower;
            }

            days++;
        }
    }
}