using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xa = 45, ya = 1,
                xb = 1, yb = 45,
                xc = 90, yc = 45;

            Console.SetCursorPosition(xa, ya);
            Console.WriteLine("*");

            Console.SetCursorPosition(xb, yb);
            Console.WriteLine("*");

            Console.SetCursorPosition(xc, yc);
            Console.WriteLine("*");
        }
    }
}
