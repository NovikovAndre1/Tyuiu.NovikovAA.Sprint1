
using Tyuiu.NovikovAA.Sprint1.Task7.V19.Lib;


namespace Tyuiu.NovikovAA.Sprint1.Task7.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("ТУТ ДОЛЖНА БЫТЬ ФОРМУЛА");


                double x;
            DataService ds = new DataService();

            Console.WriteLine("Введите значение х");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x));
            Console.ReadLine();
        }
    }
}
