using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Task4
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
                    List<int> results = list.FindAll(element => element == item);
                    if (results.Count % 2 != 0)
                    {
                        list.RemoveAll(element => element == item);
                    }
                }
                Console.WriteLine("-----------------------------");
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
