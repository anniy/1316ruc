using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2
{
    class task2
    {
        static void Main(string[] args)
        {
            string[] token;
            float a;
            float b;
            float h;
            float s;

            try
            {
                Console.Write("Enter trapezium parameter a, b, h: ");
                token = Console.ReadLine().Split();
                a = float.Parse(token[0]);
                b = float.Parse(token[1]);
                h = float.Parse(token[2]);

                s = ((a + b) / 2) * h;

                Console.WriteLine("a={0:N2}, b={1:N2}, h={2:N2}, s={3:N2}", a, b, h, s);
            }
            catch (Exception)
            {

                Console.Write("ERROR");
            }

            Console.ReadLine();
        }
    }
}
