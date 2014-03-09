using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    public class ReadNumbers
    {
        private void AddItem(Object dStruct, int item)
        {
            if (dStruct is Stack<int>)
            {
                (dStruct as Stack<int>).Push(item);
            }
            else
            {
                (dStruct as List<int>).Add(item);
            }

        }

        public void Print(Object dStruct)
        {
            Console.WriteLine("-------------------");
            if (dStruct is Stack<int>)
            {

                foreach (var item in (dStruct as Stack<int>))
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                foreach (var item in (dStruct as List<int>))
                {
                    Console.WriteLine(item);
                }
            }

        }

        public void DelEvenCountOccurrencItem(Object dStruct)
        {
            if (dStruct is Stack<int>)
            {
                Stack<int> tmpStack = new Stack<int>(dStruct as Stack<int>);
                int results = 0;
                (dStruct as Stack<int>).Clear();
                foreach (var item in tmpStack)
                {
                    results = tmpStack.Count(sitem => sitem == item);
                    if (results % 2 == 0)
                    {
                        this.AddItem(dStruct, item);
                    }
                }
            }
            else
            {
                foreach (var item in (dStruct as List<int>).ToList())
                {
                    List<int> results = (dStruct as List<int>).FindAll(element => element == item);
                    if (results.Count % 2 != 0)
                    {
                        (dStruct as List<int>).RemoveAll(element => element == item);
                    }
                }
            }
        }

        public long[] CountOccurrencItem(Object dStruct)
        {
            long[] resultArr = new long[1001];
            for (int i = 0; i < 1001; i++)
            {
                resultArr[i] = 0;
            }

            if (dStruct is Stack<int>)
            {
                int results = 0;
                foreach (var item in (dStruct as Stack<int>))
                {
                    results = (dStruct as Stack<int>).Count(sitem => sitem == item);
                    resultArr[item] = results;
                }
            }
            else
            {
                foreach (var item in (dStruct as List<int>))
                {
                    List<int> results = (dStruct as List<int>).FindAll(element => element == item);
                    resultArr[item] = results.Count;
                }
            }
          
            return resultArr;
        }

        public void DelNegativeItem(Object dStruct)
        {
            if (dStruct is Stack<int>)
            {
                Stack<int> tmpStack = new Stack<int>(dStruct as Stack<int>);
                IEnumerable<int> query = tmpStack.Where(item => item > 0);
                (dStruct as Stack<int>).Clear();
                foreach (int item in query)
                {
                    this.AddItem(dStruct, item);
                }
            }
            else
            {
                (dStruct as List<int>).RemoveAll(element => element < 0);
            }
        }

        public void Read(Object dStruct, byte numOfItem = 0)
        {
            string line;
            string[] token;
            int tmpItem;
            int count;
            
            try
            {
                line = Console.ReadLine();
                count = 0;
                while (line.Length != 0)
                {
                    token = line.Split();
                    for (int i = 0; i < token.Length; i++)
                    {
                        bool result = int.TryParse(token[i], out tmpItem);
                        if (result)
                        {
                            this.AddItem(dStruct, tmpItem);
                            count++;
                            if ((count == numOfItem) && (numOfItem != 0))
                            {
                                return;
                            }
                        }
                    }
                    line = Console.ReadLine();
                }
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Only the empty line interupt the program.");
            }
        }
    }
}
