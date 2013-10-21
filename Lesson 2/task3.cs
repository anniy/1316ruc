using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3
{
    class task3
    {
        static void Main(string[] args)
        {
            string[] token;
            float a;
            float b;
            float c;
            float p;
            float s;

            try
            {
                Console.Write("Enter triangle parameter a, b, c: ");
                token = Console.ReadLine().Split();
                a = float.Parse(token[0]);
                b = float.Parse(token[1]);
                c = float.Parse(token[2]);

                p = (a + b + c) / 2;

                p = p*(p - a)*(p - b)*(p - c);

                s = (float)Math.Sqrt(p);

                Console.WriteLine("a={0:N2}, b={1:N2}, c={2:N2}, s={3:N2}", a, b, c, s);
            }
            catch (Exception)
            {

                Console.Write("ERROR");
            }

            Console.ReadLine();

        }
    }
}
