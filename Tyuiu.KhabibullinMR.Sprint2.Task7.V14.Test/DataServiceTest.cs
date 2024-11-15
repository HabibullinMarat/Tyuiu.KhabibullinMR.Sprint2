using Tyuiu.KhabibullinMR.Sprint2.Task7.V14.Lib;

namespace Tyuiu.KhabibullinMR.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(true, res);
        }
    }
}