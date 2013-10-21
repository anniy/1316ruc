using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token;
            int num1, num2;
            int buffer; 

            Console.Write("Enter two int numbers: ");

            token = Console.ReadLine().Split();

            num1 = int.Parse(token[0]);
            num2 = int.Parse(token[1]);

            buffer = num1;
            num1 = num2;
            num2 = buffer;

            Console.Write("After swap method one: " + num1 + " " + num2 + "\n");

            num1 += num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.Write("After swap method two: " + num1 + " " + num2);

            Console.ReadLine();
        }
    }
}
