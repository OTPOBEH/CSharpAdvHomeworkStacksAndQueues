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
            else
            {
                isBallanced = false;
                break;
            }
        }
        Console.WriteLine(isBallanced ? "YES" : "NO");
    }
}