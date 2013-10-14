using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numSByte = -115; //  -44, 97, -115, 112
            byte numByte = 224;
            short numShort = 20000; // -10000, 20000, 1990
            ushort numUShort = 52130;
            int numInt = 970700000; // -1000000, 4825932, 970700000
            ulong numULong = 123456789123456789;

            Console.WriteLine("sbyte -> {0}", numSByte);
            Console.WriteLine("byte -> {0}", numByte);
            Console.WriteLine("short -> {0}", numShort);
            Console.WriteLine("ushort -> {0}", numUShort);
            Console.WriteLine("int -> {0}", numInt);
            Console.WriteLine("ulong -> {0}", numULong);
            Console.ReadLine();
        }
    }
}
