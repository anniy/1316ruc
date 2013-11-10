using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task9
{
    class Task9
    {
        static void Main(string[] args)
        {
            int n;
            int count;
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
                    if (i % 2 != 1)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            arr[j, i] = arr.GetLength(0) * i + j + 1;
                        }
                    }
                    else
                    {
                        count = 0;
                        for (int j = arr.GetLength(1) - 1; j >= 0; j--)
                        {
                            arr[j, i] = arr.GetLength(0) * i + count + 1;
                            count++;
                        }
                    }
                   
                }

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
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
