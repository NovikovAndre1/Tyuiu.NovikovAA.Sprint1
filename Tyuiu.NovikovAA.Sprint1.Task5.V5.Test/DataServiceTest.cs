
using Tyuiu.NovikovAA.Sprint1.Task5.V5.Lib;


namespace Tyuiu.NovikovAA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            int d = Convert.ToInt32(x);
            int wait = 5;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}