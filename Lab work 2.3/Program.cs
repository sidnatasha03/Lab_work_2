using System;

namespace Shershnev.Lab2.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //f(x, y, z) = 1/33 + ln(|y|)/7 + z*7 + min(x, 1/4)
            // Выводим информацию на консоль.
            Console.WriteLine("Введите x:");
            // Ждем от пользователя ввода строки для x.
            string xstr = Console.ReadLine();
            Console.WriteLine("Введите y:");
            // Ждем от пользователя ввода строки для y.
            string ystr = Console.ReadLine();
            Console.WriteLine("Введите z:");
            // Ждем от пользователя ввода строки для z.
            string zstr = Console.ReadLine();

            // Конвертируем строковой тип в тип double.
            double x = Convert.ToDouble(xstr);
            // Конвертируем строковой тип в тип double.
            double y = Convert.ToDouble(ystr);
            // Конвертируем строковой тип в тип double.
            double z = Convert.ToDouble(zstr);

            double f;
            f = 1 / 33.0 + Math.Log(Math.Abs(y)) / 7.0 + z * 7.0 + Math.Min(x, 1 / 4.0);

            // Выводим информацию о значение f.
            Console.WriteLine(f);
        }
    }
}


