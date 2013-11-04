using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            string[] token;
            token = Console.ReadLine().Split();
            int[] matrix;
            int[] matrixPositive;
            int[] matrixZero;
            int l = token.Length;
            int pos;
            int sum;
            int zero;
            matrix = new int[l];

            pos = 0;
            zero = 0;
            for (int i = 0; i < l; i++)
            {
                bool input = int.TryParse(token[i], out matrix[i]);
                if (!input)
                {
                    Console.WriteLine("ERROR");
                    return;
                }
                if (matrix[i] > 0) pos++;
                else if (matrix[i] == 0) zero++;
            }

            matrixPositive = new int[pos];
            matrixZero = new int[zero];
            pos = 0;
            sum = 0;
            zero = 0;
            for (int i = 0; i < l; i++)
            {
                if (matrix[i] > 0)
                {
                    matrixPositive[pos] = matrix[i];
                    pos++;
                }
                else if (matrix[i] < 0)
                {
                    sum += matrix[i];
                }
                else if (matrix[i] == 0)
                {
                    matrixZero[zero] = i;
                    zero++;
                }
            }

            foreach (var item in matrixPositive)
            {
                Console.Write(item + "  ");
            }

            if (pos == l)
            {
                Console.WriteLine("\nNo negative elements.");
            }
            else
            {
                Console.WriteLine("\nAverage of negative elements: {0}", (float) sum / (l - pos));
            }

            foreach (var item in matrixZero)
            {
                Console.Write(item + "  ");
            }
        }
    }
}
