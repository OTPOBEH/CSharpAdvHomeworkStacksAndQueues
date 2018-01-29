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
        var flowerField = new Queue<int>(input);

        Console.WriteLine();
        var initialCount = 0;
        var days = 0;
        var leftFlower = flowerField.Dequeue();
        flowerField.Enqueue(leftFlower);

        while (initialCount != flowerField.Count)
        {   
            initialCount = flowerField.Count - 1;

            for (int i = 0; i < initialCount; i++)
            {
                var rightFlower = flowerField.Peek();

                if (leftFlower < rightFlower)
                {
                    flowerField.Enqueue(leftFlower);
                    leftFlower = flowerField.Dequeue();
                }
                else
                {
                    leftFlower = flowerField.Dequeue();
                }
            }

            
            days++;
        }
    }
}