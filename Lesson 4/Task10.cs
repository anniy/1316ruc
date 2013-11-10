using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task10
{
    class Task10
    {
        static void Main(string[] args)
        {
            int n;
            int[,] arr;
            int j;
            int a;
            int b;
            int count;

            bool input = int.TryParse(Console.ReadLine(), out n);

            if (!input)
            {
                Console.WriteLine("ERROR");
                return;
            }

            if (n > 2)
            {
                arr = new int[n, n];

                j = n;
                a = 0;
                b = 0;
                count = 1;
                while (j > 0)
                {
                    int h = b + j - 1;
                    int g = a + j - 1;
                    int gg = a + j - 2;

                    for (int i = b; i <= h; i++)
                    {
                        arr[a, i] = count++;
                    }

                    for (int i = a + 1; i <= g; i++)
                    {
                        arr[i, h] = count++;
                    }

                    for (int i = gg; i >= b; i--)
                    {
                        arr[g, i] = count++;
                    }

                    for (int i = gg; i >= a + 1; i--)
                    {
                        arr[i, b] = count++;
                    }

                    a++;
                    b++;
                    j -= 2;
                }

                for (int i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
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
