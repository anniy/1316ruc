using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string[] token;
            token = Console.ReadLine().Split();
            int[] matrix;
            int l = token.Length;
            int index;
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

            index = 0;
            for (int i = 1; i < l; i++)
            {
                if (matrix[index] < matrix[i])
                {
                    index = i;
                }
            }
            Console.WriteLine("index = {0}", index);
        }
    }
}
