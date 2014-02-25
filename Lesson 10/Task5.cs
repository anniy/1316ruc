using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            int minNum = 0;
            int maxNum = 1000;

            List<int> list = new List<int>();
            long[] resultArr = new long [1001]; 
            try
            {
                for (int i = 0; i < 1001; i++)
                {
                    resultArr[i] = 0;
                }
                Random radnomNum = new Random();
                for (int i = 0; i < 2000; i++)
                {
                    list.Add(radnomNum.Next(minNum, maxNum));
                }
                foreach (var item in list.ToList())
                {
                    List<int> results = list.FindAll(element => element == item);
                    resultArr[item] = results.Count;
                }
                for (int i = 0; i < resultArr.Length; i++)
                {
                    if (i % 20 == 0)
                    {
                        Console.WriteLine("---------");
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine("{0} -> {1}", i, resultArr[i]);
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Only the empty line interupt the program.");
            }
        }
    }
}
