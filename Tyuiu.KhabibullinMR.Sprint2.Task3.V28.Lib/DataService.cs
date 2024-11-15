using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KhabibullinMR.Sprint2.Task3.V28.Lib
{
    public class DataService : ISprint2Task3V28
    {
        public double Calculate(double x)
        {
            double y=0;
            if (x > 1) { y = Math.Round(x + Math.Pow((Math.Cos(x * x)) / (x - 1),(x+3)),3); }
            else
            {
                if (x == 0) 
                { 
                    y = Math.Round((x * x + Math.Cos(x * x) - 11) / (x * x - Math.Sin(x * x) + 2), 3); 
                }
                else
                {
                    if (x>-32 & x < -1) { y = Math.Round(Math.Pow(Math.Cos(x) / (Math.PI - x), 2),3); }
                    else
                    {
                        if (x<32) { y = Math.Round(x + 10 * x - 7 / x, 3); }
                    }
                }
            }
            return y;
        }

    }
}
