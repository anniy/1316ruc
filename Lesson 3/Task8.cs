using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task8
{
    class Task8
    {
        static int Euclid(int n1, int n2)
        {
            if (n1 == n2)
            {
                return n1;
            }
            else
            {
                if (n1 > n2)
                {
                    return Euclid(n1 - n2, n2);
                }
                else
                {
                    return Euclid(n1, n2 - n1);
                }
            }
        }

        static void Main(string[] args)
        {
            int num1;
            int num2;
            int nod;
            int nok;

            string[] token;

            token = Console.ReadLine().Split();

            bool input1 = int.TryParse(token[0], out num1);
            bool input2 = int.TryParse(token[1], out num2);

            if (!input1 || !input2)
            {
                Console.WriteLine("ERROR");
                return;
            }

            nok = Euclid(num1, num2);
            nod = (num1 * num2) / nok;

            Console.WriteLine("NOK({0},{1}) = {2}", num1, num2, nok);
            Console.WriteLine("NOD({0},{1}) = {2}\n", num1, num2, nod);
        }
    }
}
