using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0,
                number2 = 0,
                number3 = 0;

            try
            {
                Console.Write("Enter first number: ");
                number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                number2 = int.Parse(Console.ReadLine());
                Console.Write("Enter third number: ");
                number3 = int.Parse(Console.ReadLine());
                Console.WriteLine("The sum is: {0}", number1 + number2 + number3);
            }
            catch (Exception)
            {
                Console.WriteLine("The input value is not a number;");
            }

            Console.ReadLine();
        }
    }
}
