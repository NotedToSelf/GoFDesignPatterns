using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Print p = Print.Instance();

            p.Line(5);
            p.Center("Testing");
            p.Wait();
        }
    }
}
