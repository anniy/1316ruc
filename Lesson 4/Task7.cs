using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace task7
{
    class Task7
    {
        static void Main(string[] args)
        {
            int[][] arr;
            int[] arrIndex;
            int[] arrTmp;
            int maxValue;

            string[][] line;

            int row;

            ArrayList list = new ArrayList();
            string l;

            do
            {
                l = Console.ReadLine();
                if (l == null)
                {
                    break;
                }
                list.Add(l);
            } while (l != null);

            row = list.Count;

            line = new string [row][];
            arr = new int[row][];
            arrIndex = new int[row];
            row = 0;

            foreach (string item in list)
            {
                line[row] = item.Split();
                arrTmp = new int[line[row].Length];

                for (int j = 0; j < line[row].Length; j++)
                {
                    bool input = int.TryParse(line[row][j], out arrTmp[j]);
                    if (input == false)
                    {
                        Console.WriteLine("ERROR");
                        return;
                    }
                }

                arr[row] = arrTmp;
                row++;
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                maxValue = arr[i][0];
                for (int j = 1; j < arr[i].Length; j++)
                {
                    if (maxValue < arr[i][j])
                    {
                        maxValue = arr[i][j];
                        arrIndex[i] = j;
                    }
                }
            }
            foreach (var item in arrIndex)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
