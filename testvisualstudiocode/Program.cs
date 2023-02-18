using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testvisualstudiocode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DataRequest(string userMassedge)
            {
                while (true)
                {
                    try
                    {
                        Console.Write(userMassedge);
                        string s = Console.ReadLine()!;
                        return Convert.ToInt32(s);
                    }
                    catch (System.Exception)
                    {

                        Console.WriteLine($"Ошибка! Попробуйте еще раз");
                        continue;

                    }
                }
            }

            // Запрашиваем информацию у пользователя
            double coordinateXA = DataRequest("Введите координаты точки А по оси Х: ");
            double coordinateYA = DataRequest("Введите координаты точки А по оси Y: ");
            double coordinateXB = DataRequest("Введите координаты точки B по оси Х: ");
            double coordinateYB = DataRequest("Введите координаты точки B по оси Y: ");

            // Выполняем вычисления
            double distancePoints = Math.Sqrt(Math.Pow(coordinateXB - coordinateXA, 2) + Math.Pow(coordinateYB - coordinateYA, 2));

            //Выводим результат
            Console.WriteLine($"Расстояние между точками равно {distancePoints}.");

        }
    }
}
