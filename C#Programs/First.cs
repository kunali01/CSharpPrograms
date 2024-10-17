using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class First
    {
        public First()
        {
            {
                Console.WriteLine("Hello, This is Kunali");
                int year = 2024;
                String month = "oct";

                Console.WriteLine("Month =" + month + " year=" + year);

                //2.using placeholder {} using numbering

                Console.WriteLine("Month={0} Year={1}", month, year);

                // 3. using string interpolation {} $
                Console.WriteLine($"Month ={month} Year = {year}");

            }
        }
    }
}
