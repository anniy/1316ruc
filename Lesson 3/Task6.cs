using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tesk6
{
    class Task6
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter a number: ");

            try
            {
                n = int.Parse(Console.ReadLine());

                if (n > 2)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = i + 1; j <= n + i; j++)
                        {
                            Console.Write( j + " ");    
                        }
                        Console.WriteLine();    
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
