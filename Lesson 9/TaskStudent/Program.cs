using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mark = new int[2];
            Student AKaneva = new Student("0342125476", 160156, mark);
            AKaneva.PrintData();
        }
    }
}
