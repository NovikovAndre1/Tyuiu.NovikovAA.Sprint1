
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;
using Tyuiu.NovikovAA.Sprint1.Task6.V8.Lib;


namespace Tyuiu.NovikovAA.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "Hello";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "elloH";
            Assert.AreEqual(wait, res);
        } 
    }
}