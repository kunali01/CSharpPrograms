using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPrograms
{
    internal class SumOfDigit
    {
        static void Main(string[] args)
        {
            int num = 13136;
            int sum = 0;

            int count = num;

            if(num<0)
            {
                num = - num;
            }   
            while(num > 0) 
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"sum of digit of number is  {count} is: {sum}");
       }
    }
}
