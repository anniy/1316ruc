using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
             string line;
            string[] token;
            int tmp;

            List<int> list = new List<int>();

            try
            {
                line = Console.ReadLine().ToString();

                while (line.Length != 0)
                {
                    token = line.Split();
                    for (int i = 0; i < token.Length; i++)
                    {
                        bool result = int.TryParse(token[i], out tmp);
                        if (result)
                        {
                            list.Add(tmp);
                        }
                    }
                    line = Console.ReadLine().ToString();
                }

                foreach (var item in list.ToList())
                {
                    if (item < 0)
                    {
                        list.Remove(item);
                    }
                }
                foreach (var item in list.ToList())
                {
                    Console.WriteLine("{0}", item);
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Only the empty line interupt the program.");
            }
        }
    }
}
