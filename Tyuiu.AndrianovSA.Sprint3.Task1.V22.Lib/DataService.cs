using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndrianovSA.Sprint3.Task1.V22.Lib
{
    public class DataService : ISprint3Task1V22
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k = startValue;

            while (k <= stopValue)
            {
                sumSeries += (Math.Pow(value, k) + 0.5) * Math.Cos(k);
                k++;
            }

            return Math.Round(sumSeries, 3);
        }
    }
}