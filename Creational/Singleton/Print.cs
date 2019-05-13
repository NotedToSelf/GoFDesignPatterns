using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Print
    {
        private static Print _instance = null;
        
        ConsoleColor basic = ConsoleColor.White;
        ConsoleColor selected = ConsoleColor.Green;
        
        /// <summary>
        /// Get the global print instance.
        /// If one does not exist it is created.
        /// </summary>
        /// <returns>The Print instance</returns>
        public static Print Instance()
        {
            if (_instance == null)
            {
                _instance = new Print();
            }
            return _instance;
        }

        protected Print(){}

        public ConsoleKeyInfo Wait()
        {
            return Console.ReadKey(true);
        }

        public void SetColorSelected()
        {
            Console.ForegroundColor = selected;
        }

        public void SetColorBasic()
        {
            Console.ForegroundColor = basic;
        }

        public void SetCursorCenter()
        {
            Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);
        }

        /// <summary>
        /// Prints a message to the center of the console
        /// </summary>
        public void Center(string msg)
        {
            Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, Console.CursorTop);
            Console.Write(msg);
        }

        /// <summary>
        /// Prints a message in the left 1/4 position of the current console.
        /// </summary>
        public void Left(string msg)
        {
            Console.SetCursorPosition(((Console.WindowWidth - msg.Length) / 4), Console.CursorTop);
            Console.Write(msg);
        }

        /// <summary>
        /// Prints a message in the right 3/4 position of the current console.
        /// </summary>
        public void Right(string msg)
        {
            Console.SetCursorPosition(((Console.WindowWidth - msg.Length) / 2) + ((Console.WindowWidth - msg.Length) / 4), Console.CursorTop);
             Console.Write(msg);
        }

        /// <summary>
        /// Prints Newlines to the console
        /// </summary>
        /// <param name="num">Number of newlines to print</param>
        public void Line(int num = 1)
        {
            for (int i = 0; i < num; ++i)
            {
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Clears the Console Screen
        /// </summary>
        public void Clear()
        {
            Console.Clear();
        }

    }
}