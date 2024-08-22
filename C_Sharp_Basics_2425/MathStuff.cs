using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics_2425
{
    internal class MathStuff
    {
        public static void Math_Addition()
        {
            Console.Write("Enter a number to add: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a 2nd number to add: ");
            double num2 = double.Parse(Console.ReadLine());
            double the_sum = num1 + num2;
            Console.WriteLine($"The sum is: {the_sum}");
        }
    }
}
