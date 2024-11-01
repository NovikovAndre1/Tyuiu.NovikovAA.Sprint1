
using System.Diagnostics.Metrics;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.NovikovAA.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            
            return value.Substring(1) + value.Substring(0, 1);
        }
    }
}
