using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task7
{
    class Task7
    {
        static void Main(string[] args)
        {
            DynamicList shoppingList = new DynamicList();
            //shoppingList.Add("j");
            //shoppingList.Add("b");
            //shoppingList.Add("g");
            //shoppingList.Add("c");
            //shoppingList.Add("db");
            //shoppingList.Add("da");
            //shoppingList.Add("e");
            //shoppingList.Add("f");
            //shoppingList.Add("a");

            shoppingList.Add(1);
            shoppingList.Add(9);
            shoppingList.Add(4);
            shoppingList.Add(17);
            shoppingList.Add(0);
            shoppingList.Add(-3);
            shoppingList.Add(5);
            shoppingList.Add(-10);
            shoppingList.Add(2);
            try
            {
                shoppingList.SortInt();
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("All elements must be of type integer.");
            }
            
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }


        }
    }
}
