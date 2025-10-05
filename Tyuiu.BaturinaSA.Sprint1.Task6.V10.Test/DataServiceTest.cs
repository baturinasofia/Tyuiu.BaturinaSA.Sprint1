using Tyuiu.BaturinaSA.Sprint1.Task6.V10.Lib;

namespace Tyuiu.BaturinaSA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "Так хочется уехать домой";
            var res = ds.DeleteMiddleLetter(value);
            Assert.AreEqual("Тк хочтся уехать доой", res);
        }
    }
}