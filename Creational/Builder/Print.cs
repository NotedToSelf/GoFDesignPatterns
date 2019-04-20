using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write
{
    class Print
    {
        public void Test()
        {
            string msg = "t  e  s  t  i  n  g";
            Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, Console.CursorTop);
            Console.WriteLine("t  e  s  t  i  n  g");
            Console.ReadKey(true);
        }

        public Print()
        {

        }

        public void Wait()
        {
            Console.ReadKey(true);
        }


        public void Center(string msg)
        {
            Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, Console.CursorTop);

        }

    }
}
