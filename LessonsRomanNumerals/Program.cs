using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsRomanNumerals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем информацию у пользователя
            Console.WriteLine("Введите целое положительное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Обрабатываем информацию
            do
            {
                int i = 0;
                int localNumber;
                number = number % 10;

            } while (number % 10 != number);
        }
    }
}
