﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace task3
{
    class Task3
    {
        static string Numbers(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                sb.Append(i);
                if (i != n)
                {
                    sb.Append(',');
                }
            }
            return sb.ToString();
        }

        static void Write(string str)
        {
            Console.WriteLine(str.Replace(",", "\n"));
        }

        static void Write(string str1, string str2)
        {
            try
            {
                StreamWriter writer = new StreamWriter(str2);
                using (writer)
                {
                    writer.WriteLine(str1);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            catch (IOException)
            {
                Console.WriteLine("IOException");
            }
        }

        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            string result = "";
            int n;
            bool input = int.TryParse(Console.ReadLine(), out n);

            if ((!input) || (n > 100000) || (n < 10000))
            {
                Console.WriteLine("ERROR");
                return;
            }

            watch.Start();

            result = Numbers(n);

            watch.Stop();

            Console.WriteLine("{0}\n {1}", n, result);
            Console.WriteLine("{0} sec.", (float)watch.ElapsedMilliseconds / 1000);
            Write(result, "num.txt");
            //Write(result);
        }
    }
}
