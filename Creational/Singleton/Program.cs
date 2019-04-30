using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Print p = Print.Instance();
            bool running = true;
            
            p.Line(2);
            p.Center("Printing Test Program");
            
            while (running)
            {
                p.Clear();
                Menu();
                p.Wait();
            }
        }

        static void Menu()
        {
            Print p = Print.Instance();
            
            p.Line(2);
            p.Center("Enter a message to print: ");
            p.Line(2);
            
            p.SetCursorCenter();
            string msg = Console.ReadLine();
            
            p.Line(2);
            p.SetColorSelected();
            p.Center(msg);
            p.SetColorBasic();
        }
    }
}
