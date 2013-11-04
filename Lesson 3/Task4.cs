using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task4
{
    class Task4
    {
        static float Factorial(int n)
        {
            return (n == 0) ? 1 : n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            string[] token;
            int n;
            int k;

            Console.Write("Enter two numbers: ");
            token = Console.ReadLine().Split();

            try
            {
                n = int.Parse(token[0]);
                k = int.Parse(token[1]);

                if (k < n && k > 1)
                {
                    Console.WriteLine("{0:N}", Factorial(n) / Factorial(k));    
                }
                else
                {
                    Console.WriteLine("The condition 1<K<N is not fulfilled.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
