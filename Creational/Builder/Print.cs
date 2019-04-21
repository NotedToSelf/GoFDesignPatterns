using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write
{
    class Print
    {
        public Print()
        {

        }

        public ConsoleKeyInfo Wait()
        {
            return Console.ReadKey(true);
        }


        public void Center(string msg, bool selected)
        {
            Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, Console.CursorTop);
            if (selected)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(msg);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write(msg);
            }
        }
        public void Left(string msg, bool selected)
        {
            Console.SetCursorPosition(((Console.WindowWidth - msg.Length) / 4), Console.CursorTop);
            if (selected)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(msg);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write(msg);
            }
        }

        public void Right(string msg, bool selected)
        {
            Console.SetCursorPosition( ((Console.WindowWidth - msg.Length) / 2) + ((Console.WindowWidth - msg.Length) / 4), Console.CursorTop);
            if (selected)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(msg);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write(msg);
            }
        }

        public void Line()
        {
            Console.WriteLine();
        }

        public void Clear()
        {
            Console.Clear();
        }

    }
}
