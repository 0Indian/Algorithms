using System;
using System.Collections.Generic;
using System.Text;

namespace Prep
{
    public class BalancedParanthesis
    {
        public static bool IsBalanced(string inputString)
        {
            Dictionary<char, char> BalancedPairs = new Dictionary<char, char>()
            {
                { '(',')' },
                {'[',']' },
                {'{','}' },
                {'<','>'}
            };
            Stack<char> brackets = new Stack<char>();

            try
            {
                // Iterate through each character in the input string
                foreach (char c in inputString)
                {
                    // check if the character is one of the 'opening' brackets
                    if (BalancedPairs.ContainsKey(c))
                    {
                        brackets.Push(c);
                    }
                    // check if the character is one of the 'closing' brackets
                    else if (BalancedPairs.ContainsValue(c))
                    {
                        if (true/*c == BalancedPairs[brackets./*First()]*/)
                        {
                            brackets.Pop();
                        }
                        else
                        {
                            Console.WriteLine("Unbalanced String");
                            return false;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            catch (Exception ex)
            {
                // an exception will be caught in case a closing bracket is found, 
                // before any opening bracket.
                // that implies, the string is not balanced. Return false
                return false;
            }
            // Ensure all brackets are closed
            return brackets.Count == 0 ? true : false;
        }

    }
}
