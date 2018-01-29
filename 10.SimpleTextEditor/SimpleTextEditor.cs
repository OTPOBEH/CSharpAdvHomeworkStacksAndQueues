using System;
using System.Collections.Generic;
using System.Linq;

public class SimpleTextEditor
{
    public static void Main(string[] args)
    {
        int operations = int.Parse(Console.ReadLine());
        Stack<string> previousStateCollection = new Stack<string>();
        string text = string.Empty;

        for (int i = 0; i < operations; i++)
        {
            var command = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            switch (command[0])
            {
                case "1":
                    previousStateCollection.Push(text);
                    text += command[1];
                    break;

                case "2":
                    previousStateCollection.Push(text);
                    var charsToRemove = int.Parse(command[1]);
                    text = text.Substring(0, text.Length - charsToRemove);
                    break;

                case "3":
                    var index = int.Parse(command[1]) - 1;
                    Console.WriteLine(text[index]);
                    break;

                case "4":
                    text = previousStateCollection.Pop();
                    break;
            }
        }
    }
}