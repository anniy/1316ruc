using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2
{
    class Task2
    {
        static void Fibonacci(int current, int next, int number, int counter)
        {
            if (counter < number)
            {
                Console.Write("[{0}] ", current);
                Fibonacci(next, current + next, number, counter + 1);
            }
        }

        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number: ");

            try
            {
                num = int.Parse(Console.ReadLine());
                Console.Write("The sequence of Fibonacci:  ");
                Fibonacci(0, 1, num, 1);
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
