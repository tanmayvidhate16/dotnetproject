using System;

namespace calculator_application_jenkins
{
    class Program
    {
        static void Main(string[] args)
        {
            // Validate input parameters
            if (args.Length != 3)
            {
                Console.WriteLine("Please provide two numbers and an operator.");
                return;
            }

            int num1 = Convert.ToInt32(args[0]);
            int num2 = Convert.ToInt32(args[1]);
            string symbol = args[2];

            int res;

            switch (symbol)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("Addition: " + res);
                    break;
                case "-":
                    res = num1 - num2;
                    Console.WriteLine("Subtraction: " + res);
                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine("Multiplication: " + res);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        res = num1 / num2;
                        Console.WriteLine("Division: " + res);
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
