using Tyuiu.BaturinaSA.Sprint1.Task3.V7.Lib;
namespace Tyuiu.BaturinaSA.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 100;
            var res = ds.VerstsToKilometers(x);
            Assert.AreEqual(106,68, res);
        }
    }
}
