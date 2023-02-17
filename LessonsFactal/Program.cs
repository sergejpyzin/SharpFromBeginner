using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsFactal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int xa = 30, ya = 1,
                xb = 1, yb = 30,
                xc = 30, yc = 30;

            Console.SetCursorPosition(xa, ya);
            Console.WriteLine("*");

            Console.SetCursorPosition(xb, yb);
            Console.WriteLine("*");

            Console.SetCursorPosition(xc, yc);
            Console.WriteLine("*");

            int x = xa, y = ya;

            int count = 0;

            while (count < 250000)
            {

                int what = rnd.Next(0, 3); //случайное число от 0 до 2 включительно

                if (what == 0)
                {
                    x = ((x + xa) / 2) + ((-1)^count) * ((y - ya) / 2);
                    y = ((y + ya) / 2) + ((-1)^count) * ((x - xa) / 2);
                }

                if (what == 1)
                {
                    x = ((x + xb) / 2) + ((-1) ^ count) * ((y - yb) / 2);
                    y = ((y + yb) / 2) + ((-1) ^ count) * ((x - xb) / 2);
                }

                if (what == 2)
                {
                    x = ((x + xc) / 2) + ((-1) ^ count) * ((y - yc) / 2);
                    y = ((y + yc) / 2) + ((-1) ^ count) * ((x - xc) / 2);
                }

                Console.SetCursorPosition(x, y);
                Console.WriteLine("*");
                count++;

            }
        }
    }
}
