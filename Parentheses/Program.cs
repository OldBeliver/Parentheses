using System;

namespace Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите строку со скобками: ");
            string userInput = Console.ReadLine();

            int balance = 0;
            int depth = 0;
            bool result = true;

            foreach (var symbol in userInput)
            {
                switch (symbol)
                {
                    case '(':
                        balance++;
                        break;
                    case ')':
                        balance--;
                        break;
                }

                result = balance >= 0;

                if (result == false)
                    break;

                if (balance > depth)
                    depth = balance;
            }

            if (result && balance == 0)
            {
                Console.WriteLine($"скобочное выражение корректное");
                Console.WriteLine($"максимальная глубина вложения: {depth}");
            }
            else
            {
                Console.WriteLine($"скобочное выражение не корректное");
            }
        }
    }
}
