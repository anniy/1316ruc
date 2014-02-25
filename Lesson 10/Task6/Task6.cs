using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6
{
    class Task6
    {
        static void Main(string[] args)
        {
            DynamicStack shoppingList = new DynamicStack();
            //shoppingList.Push("Milk");
            //shoppingList.Push("Honey");
            //shoppingList.Push("Olives");
            shoppingList.Push("Beer");
            try
            {
               // Console.WriteLine(shoppingList.Pop());
                Console.WriteLine(shoppingList.Contains("Beer"));
            }
            catch (NullReferenceException e)
            {

                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine("_____________________");
            foreach (var item in shoppingList.ToArray())
            {
                Console.WriteLine(item);
            }        
        }
    }
}
