using System;
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
            try
            {
                Welcome();

                Profile p = new Profile();
                p.PrintProfile();
                Exit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fatal Unhandled Exception occurred. " + ex.Message);
                Exit();
            }

        }



        //Display Opening Message
        private static void Welcome()
        {
            Console.WriteLine("\n\tProfile Builder\n");
        }

        //Display Exiting Message
        private static void Exit()
        {
            Console.WriteLine("\n\tPress any key to exit ... ");
            Console.ReadKey();
        }

        //Display Main Menu Prompt
        private static int Menu()
        {
            return 0;
            Console.WriteLine();
        }
    }
}
