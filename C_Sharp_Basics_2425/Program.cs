using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics_2425
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataTypes();
            //InputOutput();

            //MathStuff.Math_Addition();
            MathStuff.Do_Stuff();

            Console.ReadKey();
        }

        public static void Comments()
        {
            Console.WriteLine("Comments have slashes.");
            // This is a comment
            /*This
             * is
             * a
             * multiline
             * comment
             */
            Console.WriteLine("Multiline Comments start and end with /* */");
        }

        public static void DataTypes()
        {
            int myAge = 99;
            Console.WriteLine(myAge);
            char classGrade = 'A';
            Console.WriteLine(classGrade);
            
            float myFloat = 123.34F; 
            Console.WriteLine(myFloat);

            decimal myDecimal = 86.75309M;
            Console.WriteLine(myDecimal);

            double myDouble = 3.141593954872389547854947787947947947932;
            Console.WriteLine(myDouble);

            bool myBool = true;
            Console.WriteLine(myBool);

            string myString = "Mr. Sekol is the most awesome teacher I've ever had. Thank God the stars aligned to allow me to sit in Mr. Sekol's class. I've never been so lucky in my life. Mr. Wright wished he was as cool as Mr. Sekol.";
            Console.WriteLine(myString);
        }

        public static void InputOutput()
        {
            Console.Write("What is your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Hello {playerName}. How are you today? ");
            // ReadLine takes in strings. So if you want to do math, you have to cast the string to a different datatype. 

            // Let's math.
            Console.WriteLine("Welcome to my Addition Calculator");
            Console.Write("Please Enter a Number: ");
            double num_1 = double.Parse(Console.ReadLine());
            Console.Write("Please Enter a 2nd Number: ");
            double num_2 = double.Parse(Console.ReadLine());
            double the_sum = num_1 + num_2;
            Console.WriteLine($"{num_1} + {num_2} = {the_sum}");

            Console.WriteLine("Let's do multiplication");
            Console.Write("Please Enter a Number: ");
            double num_3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter a 2nd Number: ");
            double num_4 = Convert.ToDouble(Console.ReadLine());
            double the_product = num_3 * num_4;
            Console.WriteLine($"{num_3} x {num_4} = {the_product}");
        }
    }
}
