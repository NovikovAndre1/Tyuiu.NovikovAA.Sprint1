
using Tyuiu.NovikovAA.Sprint1.Task4.V30.Lib;


namespace Tyuiu.NovikovAA.Sprint1.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double e = 2;
            double wait = 1.9;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}