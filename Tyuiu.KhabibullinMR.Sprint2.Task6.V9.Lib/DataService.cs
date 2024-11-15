using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KhabibullinMR.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            switch (m, n)
            {
                case ( < 10, < 9):return $"0{n + 1}.0{m}";
                case ( < 13, < 9): return $"0{n + 1}.{m}";
                case ( < 10, < 31): return $"{n + 1}.0{m}";
                case ( < 13, < 31): return $"{n + 1}.{m}";
                case ( < 9, 31): return $"01.0{m+1}";
                case ( < 12, 31): return $"01.{m+1}";
                default: throw new ArgumentException("Такого дня в году нет/m и n не характеризуют 31 декабря");
            }
        }
    }
}
