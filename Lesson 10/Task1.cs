using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Task1
{
    public class Task1
    {
        static void Main(string[] args)
        {
            string line;
            string[] token;
            int tmp;
            int count;
            int sum;
            

            List<int> list = new List<int>();

            try
            {
                line = Console.ReadLine().ToString();
                count = 0;
                sum = 0;
                while (line.Length != 0)
                {
                    token = line.Split();
                    for (int i = 0; i < token.Length; i++)
                    {
                        bool result = int.TryParse(token[i], out tmp);
                        if ((result) && (tmp > 0))
                        {
                            list.Add(tmp);
                            sum += tmp;
                            count++;
                        }
                    }
                    line = Console.ReadLine().ToString();
                }

                Console.WriteLine("sum = {0}; average = {1:N2};", sum, (float)sum/count);

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Only the empty line interupt the program.");
            }
        }
    }
}
