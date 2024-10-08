
using Tyuiu.NovikovAA.Sprint1.Task1.V16.Lib;

namespace Tyuiu.NovikovAA.Sprint1.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double a = 3.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(16, res);
        }
    }
}