using System;
using System.IO;
using Write;
// Erik Bogeberg
// Design Patterns Implementation
// https://github.com/NotedToSelf/GoFDesignPatterns

// Implementation of Builder Design Pattern

// Concept: Profile Builder for some sort of social media site

namespace Builder
{
    class Program
    {
        public static Print o = new Print();

        static void Main(string[] args)
        {
            try
            {
                Profile p = new Profile();
                bool running = true;
                Welcome();
                int position = 1;
                while (running)
                {
                    p.PrintProfileCentered();
                    position = Menu(position, ref p, ref running);
                }
                Exit();
            }
            catch (FileNotFoundException ex)
            {
                o.Line();
                o.Center("Input file does not exist.", false);
                o.Line();
                o.Center(ex.Message, false);
                o.Line();
                Exit();
            }
            catch (Exception ex)
            {
                o.Line();
                o.Center("Fatal Unhandled Exception occurred.", false);
                o.Line();
                o.Center(ex.Message, false);
                o.Line();
                Exit();
            }

        }

        //Display Opening Message
        private static void Welcome()
        {
            Write.Print o = new Print();
            o.Center("Add Element", false);
        }

        //Display Exiting Message
        private static void Exit()
        {
            o.Center("Press any key to exit ... ", false);
            Console.ReadKey();
        }

        //Display Main Menu Prompt
        private static int Menu(int position, ref Profile p, ref bool running)
        {
            o.Line();
            o.Line();
            switch(position)
            {
                case 1:
                    o.Left("Add Element", true);
                    o.Center("Remove Element", false);
                    o.Right("Save Profile", false);
                    Console.WriteLine("\n");
                    o.Center("Exit", false);
                    break;
                case 2:
                    o.Left("Add Element", false);
                    o.Center("Remove Element", true);
                    o.Right("Save Profile", false);
                    Console.WriteLine("\n");
                    o.Center("Exit", false);
                    break;
                case 3:
                    o.Left("Add Element", false);
                    o.Center("Remove Element", false);
                    o.Right("Save Profile", true);
                    Console.WriteLine("\n");
                    o.Center("Exit", false);
                    break;
                case 4:
                    o.Left("Add Element", false);
                    o.Center("Remove Element", false);
                    o.Right("Save Profile", false);
                    Console.WriteLine("\n");
                    o.Center("Exit", true);
                    break;
            }    
            
            o.Line();
            ConsoleKeyInfo input = o.Wait();
            switch(input.Key)
            {
                case (ConsoleKey.RightArrow):
                    if (position < 4)
                    {
                        ++position;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (position > 1)
                    {
                        --position;
                    }
                    break;
                case ConsoleKey.Enter:
                    switch(position)
                    {
                        case 1:
                            p.AddElement();
                            break;
                        case 2:
                            p.RemoveElement();
                            break;
                        case 3:
                            p.SaveProfile();
                            break;
                        case 4:
                            running = false;
                            break;
                    }
                    break;
            }

            o.Clear();
            return position;

        }

        public static void Wait()
        {
            Console.ReadKey();
        }
    }
}
