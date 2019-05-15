using System;
using System.Collections.Generic;

namespace Prototype
{

    /// <summary>
    /// Implementation of Prototype Design Pattern.
    /// Fast Food ordering system that leverages Prototype to more easily create or duplicate meals from their generic templates.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Meal> myOrder = new List<Meal>();
            List<Meal> Menu = new List<Meal>();

            Menu.Add(new Burger());
            Menu.Add(new BBQSalad());
            Menu.Add(new Custom());
            
            Console.WriteLine();
            
            int i = 1;
            foreach (Meal item in Menu)
            {
                Console.WriteLine(i + ".");
                item.Display();
                Console.WriteLine();
                ++i;
            }

            Console.ReadKey();
        }
    }

}