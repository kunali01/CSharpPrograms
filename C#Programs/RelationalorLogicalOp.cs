using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class RelationalorLogicalOp
    {
        //public RelationalorLogicalOp() {

        static void Main(string[] args)
        {
        

        Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Is num1 >= num2 : " + (num1 >= num2));

            Console.WriteLine("Is num1 == num2 : " + (num1 == num2));
            Console.WriteLine("Is num1 != num2 : " + (num1 != num2));
            Console.WriteLine("Is num1 > num2 : " + (num1 > num2));
            Console.WriteLine("Is num1 < num2 : " + (num1 < num2));
    
            Console.WriteLine(" num1 and num2  : " + (num1 > 0 && num2 > 0));
            Console.WriteLine(" num1 or num2  : " + (num1 > 0 || num2 > 0));
        }
    }
  }

