using System;
using System.Collections.Generic;
using System.Linq;

class ReverseNumbers
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
        var inputs = new Stack<string>();

        for (int i = 0; i < input.Length; i++)
        {
            inputs.Push(input[i]);
        }

        for (int i = 0; i < input.Length - 1; i++)
        {
            Console.Write(inputs.Pop());
            Console.Write(" ");
        }
        Console.WriteLine(inputs.Pop());
    }
}