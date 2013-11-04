using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3
{
    class Task3
    {
        static void QuickSort(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;
            int tmp;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot) i++;
                while (arr[j] > pivot) j--;
                if (i <= j)
                {
                    tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j--;
                }
            }

            if (left < j) QuickSort(arr, left, j);
            if (right > i) QuickSort(arr, i, right);
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

            QuickSort(matrix, 0, l - 1);

            foreach (var item in matrix)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }
}
