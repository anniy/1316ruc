using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Task1;

namespace Task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            int minNum = 0;
            int maxNum = 1001;

            List<int> list = new List<int>();
            long[] resultArr;
            try
            {
                ReadNumbers rn = new ReadNumbers();
                Random radnomNum = new Random();
                for (int i = 0; i < 2000; i++)
                {
                    list.Add(radnomNum.Next(minNum, maxNum));
                }
                resultArr = rn.CountOccurrencItem(list);
                
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
