using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePrograms
{
    internal class ArmstrongNum
    {
        //public ArmstrongNum() {
        //    static void Main(string[] args)
        //    {

        //        int num = 153;
        //        int originalNum = num; 
        //        int sum = 0;

        //        while (num > 0)
        //        {
        //            int rem = num % 10;         // Extract the last digit
        //            sum += rem * rem * rem;     // Add the cube of the digit to the sum
        //            num = num / 10;             // Remove the last digit
        //        }

        //        if (sum == originalNum)
        //        {
        //            Console.WriteLine($"{originalNum} is an Armstrong number.");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{originalNum} is not an Armstrong number.");
        //        }
        //    }
    }

}

//Dry Run
//no = 153
//rem = 153 % 10 = 3
//sum = 0 + (3 * 3 * 3) = 27
//no = 153 / 10 = 15

//no = 15
//rem = 15 % 10 = 5
//sum = 27 + (5 * 5 * 5) = 152
//no = 15 / 10 = 1

//no = 1
//rem = 1 % 10 = 1
//sum = 152 + (1 * 1 * 1) = 153
//no = 1 / 10 = 0(loop ends)