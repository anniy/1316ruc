using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task7
{
    class Task7
    {
        static ulong Factorial(ulong n)
        {
            return (n == 0) ? 1 : n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            ulong n;
            int i = 0;
            ulong fact;
            ulong f;
            Console.Write("Enter two numbers: ");

            try
            {
                n = ulong.Parse(Console.ReadLine());
                fact = Factorial(n);
                f = fact;

                while (f % 10 == 0)
                {
                    f = f / 10;
                    i++;
                }

                Console.WriteLine("{0} -> {1}", fact, i);    
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
