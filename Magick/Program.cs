using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            int randomNumber = rnd.Next(1, 99);
            Console.Write("Загадываем число.");
            System.Threading.Thread.Sleep(800);
            Console.Write(".");
            System.Threading.Thread.Sleep(800);
            Console.Write(".");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine(" ");
            Console.WriteLine($"Наше число: {randomNumber}!");
            int firstRandomDigit = randomNumber / 10;
            int secondRandomDigit = randomNumber % 10;
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("*** Производим магию вычислений! ***");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"Наша первая цифра: {firstRandomDigit}");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine($"Наша вторая цифра: {secondRandomDigit}");
            Console.Write("Считаем.");
            System.Threading.Thread.Sleep(800);
            Console.Write(".");
            System.Threading.Thread.Sleep(800);
            Console.Write(".");
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(800);
            if (firstRandomDigit > secondRandomDigit) { Console.WriteLine($"Цифра {firstRandomDigit} больше чем {secondRandomDigit}!"); }
            else if (firstRandomDigit < secondRandomDigit) { Console.WriteLine($"Цифра {secondRandomDigit} больше чем {firstRandomDigit}!"); }
            else if (firstRandomDigit == secondRandomDigit) { Console.WriteLine($"Вот это повезло {firstRandomDigit} = {secondRandomDigit}"); }
            else { Console.WriteLine("Магия не сработала :("); }
        }
    }
}
