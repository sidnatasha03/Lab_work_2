using System;

namespace Shershnev.Lab2.Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Автомобиль
            Console.WriteLine("Цифравая модель автомобиля");

            // Заданные атрибуты цифровой модели
            
            // Длина окруности шины (м). 
            double Dlina;
            //Объём бензобака
            double Benz;
            //Крутящийся момент
            double Kr_Momtnt;
            //Обороты КВ
            double Oboroty;

            // Вычисляемые атрибуты цифровой модели
            // Площадь покрышки.
            double Square;
            // Радиус
            double Radius;
            //Количество теплоты, выделяющееся при полном сгорании бензина
            double Q;
            //Мощность
            double M;
             

            // Ввод информации в программу.         
            Console.WriteLine("Введите длину:");
            string DlinaStr = Console.ReadLine();
            Dlina = Convert.ToDouble(DlinaStr);

            Console.WriteLine("Введите объём бензобака:");
            string BenzStr = Console.ReadLine();
            Benz = Convert.ToDouble(BenzStr);

            Console.WriteLine("Введите крутящийся момент:");
            string Kr_MomentStr = Console.ReadLine();
            Kr_Momtnt = Convert.ToDouble(Kr_MomentStr);

            Console.WriteLine("Введите крутящийся обороты КВ:");
            string OborotyStr = Console.ReadLine();
            Oboroty = Convert.ToDouble(OborotyStr);

            // Расчет вычисляемых атрибутов.

            Radius = Math.Abs(Dlina / 2 * Math.PI);
            Square = Math.Abs(Math.PI * Math.Pow(Radius, 2));
            Q = Math.Abs(Benz * 46);
            M = Math.Abs(Kr_Momtnt * Oboroty * 9549);

            // Вывод информации на консоль.
            Console.WriteLine("Radius: " + Radius + " м ");
            Console.WriteLine("Square: " + Square + " м ");
            Console.WriteLine("M: " + Square + " H * m ");
            Console.WriteLine("Q: " + Square + " Дж ");
        }
    }
}
