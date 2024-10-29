
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.NovikovAA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double fractionalPart = x - Math.Floor(x);
            return (int)(fractionalPart * 10);
        }
    }
}
