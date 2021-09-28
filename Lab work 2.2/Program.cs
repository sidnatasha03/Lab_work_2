using System;

namespace Shershnev.Lab2.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //f(x) = 1/33 + ln(|x|)/7 + 7x + min(x, 1/4) + cos(x/3) + x^(x/3)/3

            //Выводим информацию на консоль
            Console.WriteLine("Введите x");

            //Ждём от пользователя ввода строки
            string xstr = Console.ReadLine();

            // Конвертируем строковой тип в тип double.
            double x = Convert.ToDouble(xstr);

            //Объявляем f
            double f;
            f = 1 / 33.0 + Math.Log(Math.Abs(x)) / 7.0 + 7.0 * x + Math.Min(x, 1 / 4) + Math.Cos(x / 3) + Math.Pow(x, x / 3) / 3;

            //Выводим информацию о значении y
            Console.WriteLine(f);
            Console.ReadKey();
        }

    }

}
