using Tyuiu.KhabibullinMR.Sprint2.Task4.V4.Lib;

namespace Tyuiu.KhabibullinMR.Sprint2.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 3.584;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 10.841;
            Assert.AreEqual(wait, res);
        }
    }
}