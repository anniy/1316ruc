using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    class task1
    {
        static void Main(string[] args)
        {
            int number;
            int tmpNum;
            int invertNum = 0;
            int sumOfDigit = 0;
            float quotient;
            int buffer;
            int exchange = 0;

            Console.Write("Enter the six-digit number: ");

            try
            {
                number = int.Parse(Console.ReadLine());
                tmpNum = number;
                for (int i = 0; i < 6; i++)
                {
                    buffer = tmpNum % 10;
                    tmpNum = tmpNum / 10;
                    invertNum = invertNum * 10 + buffer;
                    sumOfDigit += buffer;
                    if (i == 3)
                    {
                        exchange = (number / 100000) * 10 + buffer;
                    }
                    else if (i == 4)
                    {
                        exchange = (exchange * 10 + buffer)*1000 + (number % 1000);
                    }
                }

                quotient = (float) number / (float) sumOfDigit;
                Console.WriteLine("The invert number is: {0}\nThe sum of digit is: {1}\nThe quotient is: {2:N2}\nThe exchange number is:{3}", invertNum, sumOfDigit, quotient, exchange);
            }
            catch (Exception)
            {

                Console.WriteLine("The entered value is not a number!");
            }

            Console.ReadLine();
        }
    }
}
