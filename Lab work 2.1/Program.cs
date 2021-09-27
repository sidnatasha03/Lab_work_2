using System;

namespace Shershnev.Lab2.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дана сторона равнобедренной трапеции, найти углы и длину диагоналей.

            Console.WriteLine("Введите боковую сторону трапеции");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вверхнее основание трапеции");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите нижнее основание трапеции");
            double y = Convert.ToDouble(Console.ReadLine());

            //Диагональ трапеции
            double D = Math.Sqrt(b*b + x*y);
            Console.WriteLine("Диагональ: " + D);

            // Углы.
            double i = Math.Abs(y - x / 2);
            Console.WriteLine("Противолежащий в трапеции катет: " + i);
            double q1 = Math.Cos(i / b);
            Console.WriteLine("Угол трапеции при основании: " + q1);
            double q2 = Math.Abs(180 - q1);
            Console.WriteLine("Угол трапеции у вершины: " + q2);
        }
    }
}
