using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            string[] token;
            int min;
            int max;

            Console.Write("Enter a number: ");
            token = Console.ReadLine().Split();

            try
            {
                min = int.Parse(token[0]);
                max = int.Parse(token[0]);

                for (int i = 1; i < token.Length; i++)
                {
                    int tmp = int.Parse(token[i]);
                    if (max < tmp) max = tmp;
                    if (min > tmp) min = tmp;
                }

                Console.WriteLine("max = {0}", max);
                Console.WriteLine("min = {0}", min);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
