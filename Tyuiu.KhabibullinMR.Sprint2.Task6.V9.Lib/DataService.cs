using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KhabibullinMR.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            switch (m, n)
            {
                case (< 13,<31):return $"{m} месяц,{n + 1} число";
                case ( < 12, 31):return $"{m+1} месяц,1 число";
                default: throw new ArgumentException("Такого дня в году нет/m и n не характеризуют 31 декабря");
            }
        }
    }
}
