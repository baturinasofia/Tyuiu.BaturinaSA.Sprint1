using Tyuiu.BaturinaSA.Sprint1.Task4.V11.Lib;

namespace Tyuiu.BaturinaSA.Sprint1.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.407, res);
        }
    }
}