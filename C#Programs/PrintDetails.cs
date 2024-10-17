using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class PrintDetails
    {
        //static void Main(string[] args)
        public PrintDetails()
        {
            {

                string firstName = "Kunali";
                string lastName = "Latkar";
                string course = "MCA";
                string city = "Pune";
                int age = 26;
                int year = 2024;
                string month = "October";

                // 1. Using concatenation
                Console.WriteLine("First Name = " + firstName + ", Last Name = " + lastName + ", Course = " + course + ", City = " + city + ", Age = " + age);
                Console.WriteLine("Month = " + month + " year = " + year);

                // 2. Using placeholder {}
                Console.WriteLine("First Name = {0}, Last Name = {1}, Course = {2}, City = {3}, Age = {4}", firstName, lastName, course, city, age);
                Console.WriteLine("Month = {0}, Year = {1}", month, year);

                // 3. Using string interpolation {}
                Console.WriteLine($"First Name = {firstName}, Last Name = {lastName}, Course = {course}, City = {city}, Age = {age}");
                Console.WriteLine($"Month = {month}, Year = {year}");
            }
        }
    }
}
