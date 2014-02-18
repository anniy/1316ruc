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
            int[] mark = new int[2] {5, 6};
            Student AKaneva = new Student("8305035373", 160156, mark, "Ana", "Kaneva");
            AKaneva.PrintData();
        }
    }
}
