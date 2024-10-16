using Tyuiu.KhabibullinMR.Sprint2.Task1.V27.Lib;

namespace Tyuiu.KhabibullinMR.Sprint2.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a,b,c,d;
            a = 654;
            b = 325;
            c = 154;
            d = 333;
            var res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = [false,false,true,false,true,false];
            CollectionAssert.AreEqual(wait, res);
        }
    }
}