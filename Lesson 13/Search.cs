using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task
{
    class Search
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 5, 7, 9, 11, 13, 18, 19, 22, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            //Array.Sort(arr);
            int search = 30;
            int begin = 0;
            int end = arr.Length;
            int middle;
            while (begin <= end)
	        {
                middle = (begin + end) / 2;

	            if (arr[middle] == search)
	            {
		            Console.WriteLine("Position {0}", middle);
                    break;
	            }
                if (arr[middle] > search)
	            {
                    end = middle - 1;
	            }
                if (arr[middle] < search)
                {
                    begin = middle + 1;
                }
	        }
        }
    }
}
