
using Tyuiu.NovikovAA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.NovikovAA.Sprint1.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите положительное вещественное число x: ");
            double x = double.Parse(Console.ReadLine());

            // Проверка на положительность x
            if (x <= 0)
            {
                Console.WriteLine("Число должно быть положительным.");
                return;
            }

            // Извлечение дробной части
            double fractionalPart = x - Math.Floor(x);

            // Извлечение первой цифры дробной части
            int d = (int)(fractionalPart * 10);

            // Вывод результата
            Console.WriteLine($"Первая цифра дробной части числа {x} - это {d}");
        }
    }
}
