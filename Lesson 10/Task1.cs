using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Task1
{
    public class Task1
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();          
            try
            {
                ReadNumbers rn = new ReadNumbers();
                rn.Read(list);
                rn.DelNegativeItem(list);
                int sum = list.Sum();
                rn.Print(list);
                Console.WriteLine("sum = {0}, average = {1:N2}", sum, (float)sum/list.Count);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
