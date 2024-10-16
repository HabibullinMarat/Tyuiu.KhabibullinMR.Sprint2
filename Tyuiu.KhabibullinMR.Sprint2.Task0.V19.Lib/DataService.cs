using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KhabibullinMR.Sprint2.Task0.V19.Lib
{
    public class DataService : ISprint2Task0V19
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool [] result = new bool[6];
            result[0] = x + 72 == y;
            result[1] = x != y;
            result[2] = x < y;
            result[3] = x + 80 > y;
            result[4] = x <= y;
            result[5] = x + 90 >= y;
            return result;
        }
    }
}
