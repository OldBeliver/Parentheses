using System;

namespace Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите строку с круглыми скобками: ");
            string userInput = Console.ReadLine();

            int depth = 0;
            int maxDepth = 0;
            
            foreach (var symbol in userInput)
            {
                switch (symbol)
                {
                    case '(':
                        depth++;
                        break;
                    case ')':
                        depth--;
                        break;
                }

                if (depth < 0)
                    break;

                if (depth > maxDepth)
                    maxDepth = depth;
            }

            if (depth == 0)
            {
                Console.WriteLine($"скобочное выражение корректное");
                Console.WriteLine($"максимальная глубина вложения: {maxDepth}");
            }
            else
            {
                Console.WriteLine($"скобочное выражение не корректное");
            }
        }
    }
}
