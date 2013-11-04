using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            double n;
            int i;

            Console.Write("Enter a number: ");

            try
            {
                n = double.Parse(Console.ReadLine());

                for (i = 0; i < 10000; i++)
                {
                    if (n < 0) break;
                    n -= Math.Sqrt(n);
                }

                Console.WriteLine("result = {0}, iteration = {1}", n, i);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
