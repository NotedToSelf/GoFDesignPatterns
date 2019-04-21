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

                Welcome();
                int position = 1;
                while (true)
                {
                    p.PrintProfileCentered();
                    position = Menu(position);
                    
                    //Exit();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Input file does not exist.");
                Console.WriteLine(ex.Message);
                Exit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fatal Unhandled Exception occurred.");
                Console.WriteLine(ex.Message);
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
        private static int Menu(int position)
        {
            o.Line();
            o.Line();
            switch(position)
            {
                case 1:
                    o.Left("Add Element", true);
                    o.Center("Remove Element", false);
                    o.Right("Save Profile", false);
                    break;
                case 2:
                    o.Left("Add Element", false);
                    o.Center("Remove Element", true);
                    o.Right("Save Profile", false);
                    break;
                case 3:
                    o.Left("Add Element", false);
                    o.Center("Remove Element", false);
                    o.Right("Save Profile", true);
                    break;

            }    
            
            o.Line();
            ConsoleKeyInfo input = o.Wait();
            switch(input.Key)
            {
                case (ConsoleKey.RightArrow):
                    if (position < 3)
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
