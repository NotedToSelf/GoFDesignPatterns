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
        static void Main(string[] args)
        {
            Write.Print o = new Print();

            try
            {
                Profile p = new Profile();

                Welcome();

                /*while(true)
                {
                    o.Test();
                }*/
                while (true)
                {
                    Menu();

                    p.PrintProfile();

                    o.Wait();
                    Exit();
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
            Center("Profile Builder");
        }

        //Display Exiting Message
        private static void Exit()
        {
            Center("Press any key to exit ... ");
            Console.ReadKey();
        }

        //Display Main Menu Prompt
        private static int Menu()
        {
            Center("o p t i o n s");
            Wait();
            return 0;

        }

        //Aligns a message to the center of the console
        private static void Center(string message)
        {
            Console.SetCursorPosition((Console.WindowWidth - message.Length) / 2, Console.CursorTop);
            Console.WriteLine(message);
        }

        public static void Wait()
        {
            Console.ReadKey();
        }
    }
}
