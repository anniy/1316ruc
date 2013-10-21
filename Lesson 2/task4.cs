using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task4
{
    class task4
    {
        static void Main(string[] args)
        {
            int number;

            try
            {
                Console.Write("Enter the integer number: ");
               
                number = int.Parse(Console.ReadLine());

                Console.WriteLine("number*8 = {0}", number<<3);
            }
            catch (Exception)
            {

                Console.Write("ERROR");
            }

            Console.ReadLine();

        }
    }
}
