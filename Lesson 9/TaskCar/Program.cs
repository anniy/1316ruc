using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car CarObj = new Car("Golf 2", 1901, 10, 1000, 30);
            Car CarObj1 = new Car("Golf 3", 1901, 10, 1000, 30);
            Car CarObj2 = new Car("Golf 5", 1901, 10, 1000, 30);

            CarObj.PrintData();

            CarObj.WriteData();
            CarObj1.WriteData();
            CarObj2.WriteData();

        }
    }
}
