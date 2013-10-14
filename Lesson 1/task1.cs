using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName;

            System.Console.Write("Enter the full name: ");
            
            fullName =  Console.ReadLine();

            System.Console.WriteLine("Hello " + fullName + "!");
            Console.ReadLine();
        }
    }
}
