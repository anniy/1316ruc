using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            try
            {
                ReadNumbers rn = new ReadNumbers();
                rn.Read(list);
                rn.DelEvenCountOccurrencItem(list);
                rn.Print(list);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
