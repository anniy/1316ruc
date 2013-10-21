using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task7
{
    class task7
    {
        static void Main(string[] args)
        {
            string[] token;
            int a;
            int b;
            int c;

            try
            {
                Console.Write("Enter triangle parameter a, b, c: ");
                token = Console.ReadLine().Split();
                a = int.Parse(token[0]);
                b = int.Parse(token[1]);
                c = int.Parse(token[2]);

                if ((a < b + c) && (b < a + c) && (c < a + b))
                {
                    if (a == b && a == c && b == c) Console.WriteLine("Equilateral triangle.");
                    else if (a == b || a == c || b == c) Console.WriteLine("Isosceles triangle.");
                    else if (a != b && a != c && b != c) Console.WriteLine("Scalene triangle."); 
                }
                else
                {
                    Console.WriteLine("Is not a triangle!");
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
