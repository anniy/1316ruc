using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token;
            string str; 
            bool b;
            int i;

            Console.Write("Enter string, bool and int: ");
            token = Console.ReadLine().Split();

            try
            {
                str = token[0];
                b = bool.Parse(token[1]);
                i = int.Parse(token[2]);
                Console.WriteLine("string: " + str + "\n bool: " + b + "\n int: " + i);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong data input");
            }

            Console.ReadLine();
        }
    }
}
