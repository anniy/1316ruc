using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task6
{
    class Task6
    {
        static void Main(string[] args)
        {
            string[] token1;
            string[] token2;
            token1 = Console.ReadLine().Split();
            token2 = Console.ReadLine().Split();
            int[] matrix1;
            int[] matrix2;
            int[] matrix3;
            int l1 = token1.Length;
            int l2 = token2.Length;
            int l3;
            matrix1 = new int[l1];
            matrix2 = new int[l2];

            for (int i = 0; i < l1; i++)
            {
                bool input = int.TryParse(token1[i], out matrix1[i]);
                if (input == false)
                {
                    Console.WriteLine("ERROR");
                    return;
                }
            }

            for (int i = 0; i < l2; i++)
            {
                bool input = int.TryParse(token2[i], out matrix2[i]);
                if (input == false)
                {
                    Console.WriteLine("ERROR");
                    return;
                }
            }
            l3 = 0;
            for (int i = 0; i < l1; i++)
            {
                for (int j = 0; j < l2; j++)
                {
                    if (matrix1[i] == matrix2[j])
                    {
                        l3++;
                        break;
                    }
                }
            }

            matrix3 = new int[l3];
            
            l3 = 0;
            for (int i = 1; i < l1; i++)
            {
                for (int j = 0; j < l2; j++)
                {
                    if (matrix1[i] == matrix2[j])
                    {
                        matrix3[l3] = matrix1[i];
                        l3++;
                        break;
                    }
                }
            }

            foreach (var item in matrix3)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }
}
