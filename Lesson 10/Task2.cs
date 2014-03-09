using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            byte n;

            Console.Write("Enter the count of integer number = ");
            try
            {
                n = byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter the {0} integer number:", n);
                ReadNumbers rn = new ReadNumbers();
                rn.Read(stack, n);
                Console.WriteLine("-------------------");
                foreach (var item in stack)
                {
                    if (item > 0)
                    {
                        Console.WriteLine(item);
                    }
                }              
            }
            catch (FormatException)
            {
                Console.WriteLine("The value is not a positively integer number.");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
