using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsChetNechet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int count = 0;
                int chet = 0;
                int nechet = 0;
                int length;
                int sumChet = 0;
                int sumNechet = 0;

                try
                {
                    Console.Write("Введите желаемый диапазон: ");
                    length = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! Не удалось преобразовать строку в число. Введите корректный диапазон");
                    Console.ReadLine();
                    continue;
                      
                }
                
                Console.WriteLine($"Четные числа \tНечетные числа");

                while (count <= length)
                {
                    if (count % 2 == 0)
                    {
                        sumChet = sumChet + count;
                        Console.WriteLine(count);
                        chet++;

                    }
                    else
                    {
                        sumNechet= sumNechet + count;
                        Console.WriteLine($"\t\t {count}");
                        nechet++;
                    }
                    count++;
                }
                Console.WriteLine($"В данном диапазоне четных чисел - {chet}; \t\nих сумма - {sumChet}");
                Console.WriteLine($"В данном диапазоне нечетных чисел - {nechet}; \t\nих сумма - {sumNechet}");
                Console.ReadLine();
            }
        }
    }
}
