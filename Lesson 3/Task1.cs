using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            string[] token;
            int[] number;
            number = new int[5];
            int sum = 0;

            Console.Write("Enter five integer number: ");
            token = Console.ReadLine().Split();

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    number[i] = int.Parse(token[i]);
                    sum += number[i];
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The number is not integer!");
            }

            if (sum == 0)
            {
                //двойки числа
                for (int i = 0; i < number.Length - 1; i++)
                {
                    for (int j = i + 1; j < number.Length; j++)
                    {
                        if (number[i] + number[j] == 0)
                            Console.WriteLine("{0} + {1} = 0", number[i], number[j]);
                    }
                }

                //тройки числа
                for (int i = 0; i < number.Length - 2; i++)
                {
                    for (int j = i + 1; j < number.Length - 1; j++)
                    {
                        for (int k = j + 1; k < number.Length; k++)
                        {
                            if (number[i] + number[j] + number[k] == 0)
                                Console.WriteLine("{0} + {1} + {2} = 0", number[i], number[j], number[k]);
                        }
                    }
                }

                //четворки числа
                for (int i = 0; i < number.Length - 3; i++)
                {
                    for (int j = i + 1; j < number.Length - 2; j++)
                    {
                        for (int k = j + 1; k < number.Length - 1; k++)
                        {
                            for (int l = k + 1; l < number.Length; l++)
                            {
                                if (number[i] + number[j] + number[k] + number[l] == 0)
                                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", number[i], number[j], number[k], number[l]);
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("The sum is not zero!");
            }
        }
    }
}
