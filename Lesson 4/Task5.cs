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
            int l = token.Length;
            int j = 0;
            int sum;
            matrix = new int[l];

            for (int i = 0; i < l; i++)
            {
                bool input = int.TryParse(token[i], out matrix[i]);
                if (!input)
                {
                    Console.WriteLine("ERROR");
                    return;
                }
                if (matrix[i] > 0) j++;
            }
            matrixPositive = new int[j];
            j = 0;
            sum = 0;
            for (int i = 0; i < l; i++)
            {
                if (matrix[i] > 0)
                {
                    matrixPositive[j] = matrix[i];
                    j++;
                }
                else if (matrix[i] < 0)
                {
                    sum += matrix[i];
                } 
            }

            foreach (var item in matrixPositive)
            {
                Console.Write(item + "  ");
            }

            if (j == l)
            {
                Console.WriteLine("\nNo negative elements.");
            }
            else
            {
                Console.WriteLine("\nAverage of negative elements: {0}", (float) sum / (l - j));
            } 
        }
    }
}
