using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task8
{
    class task8
    {
        static void Main(string[] args)
        {
            string[] token;
            float a;
            float b;
            float c;
            float d;
            float x1;
            float x2;

            try
            {
                Console.Write("Enter the parameters a, b, c: ");
                token = Console.ReadLine().Split();
                a = float.Parse(token[0]);
                b = float.Parse(token[1]);
                c = float.Parse(token[2]);

                if (a != 0)
                {
                    d = (b * b) - (4 * a * c);
                    if (d > 0)
                    {
                        x1 = (-b + (float)Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - (float)Math.Sqrt(d)) / (2 * a);
                        Console.WriteLine("D={0}, x1= {1}, x2= {2}", d, x1, x2);
                    }
                    else if (d == 0)
                    {
                        x1 = -b / (2 * a);
                        Console.WriteLine("D={0}, x= {1}", d, x1);
                    }
                    else if (d < 0)
                    {
                        Console.WriteLine("Equation has no real roots!");
                    }
                }
                else
                {
                    Console.WriteLine("Is not a quadratic equation!");
                }
            }
            catch (Exception)
            {

                Console.Write("ERROR");
            }

            Console.ReadLine();



        }
    }
}
