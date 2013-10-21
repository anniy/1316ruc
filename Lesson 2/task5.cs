using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task5
{
    class task5
    {
        static void Main(string[] args)
        {
            string[] token;
            string name;
            string pin ;
            string phone;
       
            Console.Write("Enter your name, PIN and phone: ");
            token = Console.ReadLine().Split();

            name = token[0];
            pin = token[1];
            phone = token[2];

            Console.WriteLine("Hello \"{0}\" your ID is: \"{1}\" and your phone number is \"{2}\"", name, pin, phone);

            Console.ReadLine();
        }
    }
}
