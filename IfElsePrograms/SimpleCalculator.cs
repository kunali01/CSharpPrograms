using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePrograms
{
    internal class SimpleCalculator
    {
        static void Main(string[] args)
        {
            double num1 = 10, num2 = 20;
            char op = '*';
            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("cannot divide by zero");
                    return;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }
            Console.WriteLine($"Result is : {num1} {op} {num2} = {result}");

            }
    }
}
