using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            string[] token;
            token = Console.ReadLine().Split();
            int[] number;
            int l = token.Length;
            int sum = 0;
            number = new int[l];

            for (int i = 0; i < l; i++)
			{
			    bool input = int.TryParse(token[i], out number[i]);
                if (input == false)
                {
                    Console.WriteLine("ERROR");
                    return;
                }
                sum += number[i]; 
			}
            Console.WriteLine(sum);
        }
    }
}
