using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task7
{
    class Task7
    {
        static void Main(string[] args)
        {
            int n;
            int count2 = 0;
            int count5 = 0;
            Console.Write("Enter a numbers: ");

            try
            {
                n = int.Parse(Console.ReadLine());


                for (int i = n; i >= 1; i--)
                {
                    if (i % 2 == 0)
                    {
                        count2++;
                    }
                    if (i % 5 == 0)
                    {
                        count5++;
                    }
                }

                if (count5 == count2)
                {
                    Console.WriteLine("N! -> {0}", count5);    
                }
                else if (count5 < count2)
                {
                    Console.WriteLine("N! -> {0}", count5);    
                }
                else if (count5 > count2)
                {
                    Console.WriteLine("N! -> {0}", count2);
                }

                
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
