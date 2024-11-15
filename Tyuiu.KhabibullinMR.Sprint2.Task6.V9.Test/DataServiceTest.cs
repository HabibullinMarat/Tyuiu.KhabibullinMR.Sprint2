using Tyuiu.KhabibullinMR.Sprint2.Task6.V9.Lib;

namespace Tyuiu.KhabibullinMR.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("5,25", ds.FindDateOfNextDay(5, 24));
            Assert.AreEqual("6,1", ds.FindDateOfNextDay(5, 31));
            Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfNextDay(15,44));
        }
    }
}