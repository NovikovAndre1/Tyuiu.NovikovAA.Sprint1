
using Tyuiu.NovikovAA.Sprint1.Task3.V14.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Tyuiu.NovikovAA.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 3;
            int z = 4;
            var res = ds.ReverseNumber(234);
            Assert.AreEqual(432, res);
        }
    }
}