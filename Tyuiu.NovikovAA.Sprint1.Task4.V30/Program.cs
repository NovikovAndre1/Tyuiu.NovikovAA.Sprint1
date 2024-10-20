
using Tyuiu.NovikovAA.Sprint1.Task4.V30.Lib;


namespace Tyuiu.NovikovAA.Sprint1.Task4.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");
            int x, y, e;

            Console.WriteLine("Введите значение х:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение e:");
            e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("(x + y ^ 3) / (e ^ 2 - y) = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
