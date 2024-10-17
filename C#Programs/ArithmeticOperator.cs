using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class ArithmeticOperator
    {
        public ArithmeticOperator()
        {
            //static void Main(string[] args)
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());


                double addition = num1 + num2;
                double subtraction = num1 - num2;
                double multiplication = num1 * num2;
                double division = num1 / num2;
                double modulus = num1 % num2;


                Console.WriteLine("\nResults:");
                Console.WriteLine("Addition: " + addition);
                Console.WriteLine("Subtraction: " + subtraction);
                Console.WriteLine("Multiplication: " + multiplication);
                Console.WriteLine("Division (with precision): " + division);
                Console.WriteLine("Modulus: " + modulus);
            }
        }
    }
}

