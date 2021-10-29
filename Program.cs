using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean run = true;

            Console.Write("Simple calculator.\nBy ThIsIsTails\nVersion 0.1 RELEASE\n\n");

            while (run)
            {

                int first;
                char param;
                int second;

                Console.Write("Enter first number: ");
                first = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter param char (*, +, -, /): ");
                param = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter second number: ");
                second = Convert.ToInt32(Console.ReadLine());

                switch (param)
                {
                    case '*':
                        Console.WriteLine("Result: " + Convert.ToString(first * second) + "\n");
                        break;
                    case '+':
                        Console.WriteLine("Result: " + Convert.ToString(first + second) + "\n");
                        break;
                    case '-':
                        Console.WriteLine("Result: " + Convert.ToString(first - second) + "\n");
                        break;
                    case '/':
                        Console.WriteLine("Result: " + Convert.ToString(first / second) + "\n");
                        break;
                    default:
                        Console.WriteLine("Parametr is not allowed! Use only *, +, -, /.");
                        break;
                }

                Console.WriteLine("Do you want continue(y) or exit(n)? (y/n)");
                run = Console.ReadLine().ToLower() == "y";
            }

            Console.WriteLine("\n\nGoodbye! See you next time!");
            Console.ReadKey();

        }
    }
}
