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
            int num;
            int[,] matrix;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            matrix = new int[num, num];
            int count = 1;

            int a = 0;
            int b = 0;
            int n = num;

            while (n > 0)
            {
                for (int i = b; i <= b + n - 1; i++)
                {
                    matrix[a, i] = count++;
                }

                for (int i = a + 1; i <= a + n - 1; i++)
                {
                    matrix[i, b + n - 1] = count++;
                }

                for (int i = b + n - 2; i >= b; i--)
                {
                    matrix[a + n - 1, i] = count++;
                }

                for (int i = a + n - 2; i >= a + 1; i--)
                {
                    matrix[i, b] = count++;
                }

                a = a + 1;
                b = b + 1;
                n = n - 2;
            }

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
        }
    }
}
