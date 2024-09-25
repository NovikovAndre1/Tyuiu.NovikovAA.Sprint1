using Tyuiu.NovikovAA.Sprint1.Task0.V7.Lib;


namespace Tyuiu.NovikovAA.Sprint1.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(5, res);

        }
    }
}