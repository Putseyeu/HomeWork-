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
            string text = "(()(()))";
            int checkNumber = 0;
            int nestingDepth;
            int counterOpen = 0;
            int counterClose = 0;
            int parityDivisor = 2;
            int uncountedParenthesisPair = 1;

            foreach (var symbol in text)
            {
                if (symbol == '(')
                {
                    checkNumber++;
                    counterOpen++;
                }
                if (symbol == ')')
                {
                    checkNumber--;
                    counterClose++;
                }
                if (checkNumber < 0)
                {
                    Console.WriteLine($" {text} - Строка не является корректным скобочным выражением");
                    break;
                }
            }
         
            if (checkNumber == 0)
            {
                nestingDepth = (counterOpen + counterClose) / parityDivisor - uncountedParenthesisPair;
                Console.WriteLine($" {text} - Строка является корректным скобочным выражением  с глубиной вложения  {nestingDepth}");
            }            
        }
    }
}
