using System;

namespace Shershnev.Lab2.Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дерево
            Console.WriteLine("Цифравая модель автомобиля");

            // Заданные атрибуты цифровой модели
            
            // Длина окруности шины (м). 
            double Dlina;

            // Вычисляемые атрибуты цифровой модели
            // Площадь покрышки.
            double Square;
            //  Радиус
            double Radius;

            // Ввод информации в программу.         
            Console.WriteLine("Введите Dlina:");
            string DlinaStr = Console.ReadLine();
            Dlina = Convert.ToDouble(DlinaStr);

            // Расчет вычисляемых атрибутов.

            Radius = Math.Abs(Dlina / 2 * Math.PI);
            Square = Math.Abs(Math.PI * Math.Pow(Radius, 2));
            

            // Вывод информации на консоль.
            Console.WriteLine("Radius: " + Radius + " м ");
            Console.WriteLine("Square: " + Square + " м ");
        }
    }
}
