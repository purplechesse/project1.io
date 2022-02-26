using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            string a = age.ToString();
            // TEST TEST
            Console.WriteLine("Your age is: " + a);


            Console.ReadLine();
        }
    }
}
