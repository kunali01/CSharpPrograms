using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class UserInput
    {
        //static void Main(string[] args)
        public UserInput()
        {
            {
                Console.WriteLine("enter the name");
                String name = Console.ReadLine();

                Console.WriteLine("Enter age ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Course");
                String course = Console.ReadLine();
            }
        }
    }
}

