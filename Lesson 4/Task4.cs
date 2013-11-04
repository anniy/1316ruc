using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task4
{
    class Task4
    {
        static void Sort(int[] arr, int n)
        {
            int tmp;
            int index;

            for (int i = 0; i < n - 1; i++)
            {
                index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if ((Math.Abs(arr[j]) < Math.Abs(arr[index])) || ((Math.Abs(arr[j]) == Math.Abs(arr[index])) && (arr[j] < arr[index])))
                    {
                        index = j;
                    }
                }
                if (index != i)
                {
                    tmp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = tmp;
                }
            }
        }

        static void Main(string[] args)
        {
            string[] token;
            token = Console.ReadLine().Split();
            int[] matrix;
            int l = token.Length;
            matrix = new int[l];

            for (int i = 0; i < l; i++)
            {
                bool input = int.TryParse(token[i], out matrix[i]);
                if (input == false)
                {
                    Console.WriteLine("ERROR");
                    return;
                }
            }

            Sort(matrix, l);

            foreach (var item in matrix)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }
}
