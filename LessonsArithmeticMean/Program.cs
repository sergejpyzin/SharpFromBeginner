using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsArithmeticMean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя два числа
            Console.WriteLine("Введите первое число: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите второе число: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            // Находим среднеарифметическое
            int result = (numberA + numberB) / 2;

            // Выводим информацию на консоль
            Console.WriteLine(result);

        }
    }
}
