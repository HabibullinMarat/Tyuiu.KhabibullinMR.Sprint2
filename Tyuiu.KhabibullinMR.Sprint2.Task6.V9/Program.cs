using Tyuiu.KhabibullinMR.Sprint2.Task6.V9.Lib;

namespace Tyuiu.KhabibullinMR.Sprint2.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной M:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной N:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.FindDateOfNextDay(m, n));
        }
    }
}
