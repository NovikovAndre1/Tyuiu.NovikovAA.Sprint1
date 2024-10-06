
using Tyuiu.NovikovAA.Sprint1.Task1.V16.Lib;

//написать программу которая запрашивает у пользователя исходные данные,
//Вычисляет результат по формуле x*5*y+2*a и печатает его на экране.


namespace Tyuiu.NovikovAA.Sprint1.Task1.V16;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Новиков А. А. | ИИПБ-24-1";
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* спринт #1                                                             *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                            *");
        Console.WriteLine("* Задание 1 *");
        Console.WriteLine("* Вариант 16 *");
        Console.WriteLine("Выполнил: Новиков Андрей Андреевич  ИИПБ - 24 - 1");
        Console.WriteLine("******************************************************");
        Console.WriteLine("УСЛОВИЕ:");
        Console.WriteLine("* написать программу которая запрашивает у пользователя исходные данные *");
        Console.WriteLine("*Вычисляет результат по формуле x*5*y+2*a и печатает его на экране.\r\n*");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
        Console.WriteLine("***************************************************************************");
        

        double x, y, a;

        Console.WriteLine("Введите значение х:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение y:");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение a:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ *");
        Console.WriteLine("***************************************************************************");

        //Метод Calculate находится в библиотеке Tyuiu.NovikovAA.Sprint1.Task1.V16.Lib;
        // В классе DataService
        Console.WriteLine(ds.Calculate(x, y, a));

        Console.ReadLine();
    }
}
