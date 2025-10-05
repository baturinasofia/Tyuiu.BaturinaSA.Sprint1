using Tyuiu.BaturinaSA.Sprint1.Task2.V15.Lib;

namespace Tyuiu.BaturinaSA.Sprint1.Task2.V15.Test
{
    public class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            var res = ds.CalculateCubeVolume(x);
            Assert.AreEqual(27, res);
        }
    }
}