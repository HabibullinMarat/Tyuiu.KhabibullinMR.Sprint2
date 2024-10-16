using Tyuiu.KhabibullinMR.Sprint2.Task0.V19.Lib;

namespace Tyuiu.KhabibullinMR.Sprint2.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 177;
            bool[] wait = [true, true, true, true, true, true];
            var res = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}