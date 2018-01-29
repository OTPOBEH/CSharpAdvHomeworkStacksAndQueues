using System;
using System.Collections.Generic;
using System.Linq;

class BalancedParenthesis
{
    static void Main()
    {
        var input = Console.ReadLine();

        var checkImpression    = new Stack<char>();
        var openingParenthesis = new[] { '(', '[', '{' };
        var closingParenthesis = new[] { ')', ']', '}' };

        if (input.Length % 2 != 0 || closingParenthesis.Contains(input[0]))
        {
            Console.WriteLine("NO");
            return;
        }

        var isBallanced = true;

        foreach (var currentParenthesis in input)
        {
            if (openingParenthesis.Contains(currentParenthesis))
            {
                checkImpression.Push(currentParenthesis);
            }
            else if (checkImpression.Count != 0)
            {
                var openingIndex = Array.IndexOf(openingParenthesis, checkImpression.Peek());
                var closingIndex = Array.IndexOf(closingParenthesis, currentParenthesis);

                if (openingIndex != closingIndex)
                {
                    isBallanced = false;
                    break;
                }
                checkImpression.Pop();
            }
        }
        Console.WriteLine(isBallanced ? "YES" : "NO");
    }
}