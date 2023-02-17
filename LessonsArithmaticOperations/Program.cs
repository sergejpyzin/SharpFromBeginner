using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsArithmaticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя информацию
            Console.WriteLine("Введите первое число: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int numberC = Convert.ToInt32(Console.ReadLine());

            // Выполняем условия задачи
            int resSum = numberA+ numberB + numberC;
            int resMult = numberA * numberB * numberC;

            // Выводим результат в консоль
            Console.WriteLine($"Сумма введенных чисел равна - {resSum}; Произведение введенных чисел равно - {resMult}");
            Console.ReadLine();
        }
    }
}
