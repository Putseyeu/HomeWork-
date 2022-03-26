using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "(()(())())";
            int checkNumber;
            int nestingDepth = 0;
            int counterOpen = 0;
            int counterClose = 0;
            int parityDivisor = 2;
            int uncountedParenthesisPair = 1;

            foreach (var symbol in text)
            {
                nestingDepth++;
                if (symbol == '(')
                {
                    counterOpen++;
                }
                if (symbol == ')')
                {
                    counterClose++;
                }
            }

            checkNumber = counterOpen - counterClose;           
            if (checkNumber == 0)
            {
                nestingDepth = (counterOpen + counterClose) / parityDivisor - uncountedParenthesisPair;
                Console.WriteLine($" {text} - Строка является корректным скобочным выражением  с глубиной вложения  {nestingDepth}");
            }
            else
            {
                Console.WriteLine($" {text} - Строка не является корректным скобочным выражением");
            }
        }
    }
}
