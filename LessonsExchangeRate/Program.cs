using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsExchangeRate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запраштваем информацию у пользователя
            Console.WriteLine("Введите тип реализуемой валюты: 1 - доллар США, 2 - Российский рубль.");
            int Exchange = Convert.ToInt32(Console.ReadLine());


            // Реализуем калькулятор валют
            double result, cash;
            switch (Exchange)
            {
                case 1:
                    Console.Write("Введите сумму: ");
                    cash = Convert.ToInt32(Console.ReadLine());
                    result = cash * 70.79;
                    Console.WriteLine($"Ваша сумма равна {result} - Российских рублей");
                    break;
                case 2:
                    Console.Write("Введите сумму: ");
                    cash = Convert.ToInt32(Console.ReadLine());
                    result = cash / 80.71;
                    Console.WriteLine($"Ваша сумма равна {result} - Долларов США");
                    break;
                default:
                    Console.WriteLine("Неизвестный тип валюты");
                    break;

                    
            }
            
        }
    }
}
