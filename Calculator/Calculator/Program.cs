using System;

namespace Calculator
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, would you like to use the calculator?");
            string answer = Console.ReadLine();

            if (answer.Equals("y"))
            {
                Console.WriteLine("Choose between +, -, /, *");
                string option = Console.ReadLine();

                if (option.Equals("+"))
                {
                    Console.WriteLine("Input the first number");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the second number");
                    int num2 = int.Parse(Console.ReadLine());
                    int sum = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2} ", num1, num2, sum);
                    Console.ReadKey();
                }

                if (option.Equals("-"))
                {
                    Console.WriteLine("Input the first number");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the second number");
                    int num2 = int.Parse(Console.ReadLine());
                    int sum = num1 - num2;
                    Console.WriteLine("{0} - {1} = {2} ", num1, num2, sum);
                    Console.ReadKey();
                }

                if (option.Equals("/"))
                {
                    Console.WriteLine("Input the first number");
                    
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the second number");
                    int num2 = int.Parse(Console.ReadLine());
                    int sum = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2} ", num1, num2, sum);
                    Console.ReadKey();
                }

                if (option.Equals("*"))
                {
                    Console.WriteLine("Input the first number");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the second number");
                    int num2 = int.Parse(Console.ReadLine());
                    int sum = num1 * num2;
                    Console.WriteLine("{0} * {1} = {2} ", num1, num2, sum);
                    Console.ReadKey();
                }
            }

            if (answer.Equals("n"))
            {
                return;
            }
        }
    }
}
