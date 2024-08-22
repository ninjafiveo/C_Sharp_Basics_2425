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
        public static void Do_Stuff()
        {
            Console.WriteLine("Welcome to the Mathenator. What type of math would you like to do. Enter the number. \n1. Addition\n2. Subtraction\n3. Multiplication\n4.Division");
            double math_selection = double.Parse(Console.ReadLine());

            if (math_selection == 1 )
            {
                Math_Addition();
            }else if (math_selection == 2 ) { 
                Math_Division();
            }else if(math_selection == 3 )
            {
                Math_Multiplication();
            }else if(math_selection == 4) {
                Math_Division();
            }
            else
            {
                Console.WriteLine("You must enter 1, 2, 3, or 4.");
                Do_Stuff();
            }
        }
        public static void Math_Addition()
        {
            Console.Write("Enter a number to add: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a 2nd number to add: ");
            double num2 = double.Parse(Console.ReadLine());
            double the_sum = num1 + num2;
            Console.WriteLine($"The sum is: {the_sum}");
        }

        public static void Math_Subtraction()
        {
            Console.Write("Enter a number to subtract: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a 2nd number to subtract: ");
            double num2 = double.Parse(Console.ReadLine());
            double the_difference = num1 - num2;
            Console.WriteLine($"The difference is: {the_difference}");
        }

        public static void Math_Multiplication()
        {
            Console.Write("Enter a number to multiply: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a 2nd number to multiply: ");
            double num2 = double.Parse(Console.ReadLine());
            double the_product = num1 * num2;
            Console.WriteLine($"The product is: {the_product}");
        }

        public static void Math_Division()
        {
            Console.Write("Enter a number to division: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a 2nd number to division: ");
            double num2 = double.Parse(Console.ReadLine());
            double the_quotient = num1 / num2;
            Console.WriteLine($"The quotient is: {the_quotient}");
        }
    }
}
