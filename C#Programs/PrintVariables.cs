using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class PrintVariables
    {
        //static void Main(string[] args)
        public PrintVariables()
        { 
            
            {
                int age = 26;
                String name = "Kunali";
                float num = 25.55f;
                decimal salary = 65000;
                double num2 = 35.20;

                bool user = true;
                //using concatination
                Console.WriteLine("Age is :" + age + "name is" + name);

                // 2. Using placeholder {}
                Console.WriteLine("age == {0}, name == {1}, num == {2}, num2 == {3}, user == {4}, salary == {5}",
               age, name, num, num2, user, salary);

                // 3. Using string interpolation {}
                Console.WriteLine($"my age is == {age}, name is == {name}, num is == {num}, user is == {user}, salary is == {salary}");

            }
        }
    }
}
