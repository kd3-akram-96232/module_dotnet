using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
 

 internal class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            Console.WriteLine($"Result = {result}");
        }
    }
}
