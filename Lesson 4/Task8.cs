using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task8
{
    class Task8
    {
        static void Main(string[] args)
        {
            int n;
            int[,] arr;
            
            bool input = int.TryParse(Console.ReadLine(), out n);

            if (!input)
            {
                Console.WriteLine("ERROR");
                return;
            }

            if (n > 2)
            {
                arr = new int[n, n];

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = i + j + 1;
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Enter the number > 2");
            }
        }
    }
}
