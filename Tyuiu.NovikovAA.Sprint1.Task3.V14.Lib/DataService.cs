
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.NovikovAA.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            // Преобразуем число в строку
            string numberString = number.ToString();

            // Разбиваем строку на отдельные символы (цифры)
            char[] digits = numberString.ToCharArray();

            // Переворачиваем массив символов
            Array.Reverse(digits);

            // Преобразуем обратно в строку
            string reversedString = new string(digits);

            // Преобразуем строку обратно в double
            return Convert.ToDouble(reversedString);
        }
    }
}
