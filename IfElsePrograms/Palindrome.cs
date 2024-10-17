using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePrograms
{
    internal class Palindrome
    {
        //static void Main(string[] args)
        
        //    {
        //        Console.Write("Enter a number: ");
        //        int num = int.Parse(Console.ReadLine());

        //        int originalNum = num;
        //        int reversedNum = 0;

        //        while (num > 0)
        //        {
        //            int digit = num % 10; // Get last digit
        //            reversedNum = reversedNum * 10 + digit; // Build reversed number
        //            num = num / 10; // Remove last digit
        //        }

        //        if (originalNum == reversedNum)
        //        {
        //            Console.WriteLine($"{originalNum} is a palindrome.");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{originalNum} is not a palindrome.");
        //        }
        //    }

        //}
    }
}

//no = 121
//rem = 121 % 10 = 1
//reversedNum = 0 * 10 + 1 = 1
//no = 121 / 10 = 12

//no = 12
//rem = 12 % 10 = 2
//reversedNum = 1 * 10 + 2 = 12
//no = 12 / 10 = 1

//no = 1
//rem = 1 % 10 = 1
//reversedNum = 12 * 10 + 1 = 121
//no = 1 / 10 = 0(loop ends)