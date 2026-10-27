using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndrianovSA.Sprint3.Task0.V9.Lib
{
    public class DataService : ISprint3Task0V9
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                sumSeries += Math.Pow((1.0 / (3.0 + Math.Pow(value, i))), i);
            }

            return Math.Round(sumSeries, 3);
        }
    }
}