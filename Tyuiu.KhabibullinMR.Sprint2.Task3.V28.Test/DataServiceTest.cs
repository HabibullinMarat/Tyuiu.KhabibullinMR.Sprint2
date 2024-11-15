using Tyuiu.KhabibullinMR.Sprint2.Task3.V28.Lib;

namespace Tyuiu.KhabibullinMR.Sprint2.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds  = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 1.881;
            Assert.AreEqual(wait,res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -5;
            Assert.AreEqual(wait,res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = -16;
            double res = ds.Calculate(x);
            double wait = 0.003;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -40;
            double res = ds.Calculate(x);
            double wait = -439.825;
            Assert.AreEqual(wait, res);
        }
    }
}