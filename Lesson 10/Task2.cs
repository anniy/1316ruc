using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string line;
            string[] token;
            int tmp;
            
            Stack<int> stack = new Stack<int>();

            try
            {
                line = Console.ReadLine().ToString();

                while (line.Length != 0)
                {
                    token = line.Split();
                    for (int i = 0; i < token.Length; i++)
                    {
                        bool result = int.TryParse(token[i], out tmp);
                        if ((result) && (tmp > 0))
                        {
                            stack.Push(tmp);
                        }
                    }
                    line = Console.ReadLine().ToString();
                }

                foreach (var item in stack)
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
