using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task6
{
    class task6
    {
        static void Main(string[] args)
        {
            string[] token;
            int number;
            
            try
            {
                Console.Write("Enter the integer number: ");
                
                number = int.Parse(Console.ReadLine());

                Console.WriteLine((number > 0) ? "Positive" : "Negative");
            }
            catch (Exception)
            {

                Console.Write("ERROR");
            }

            Console.ReadLine();

        }
    }
}
