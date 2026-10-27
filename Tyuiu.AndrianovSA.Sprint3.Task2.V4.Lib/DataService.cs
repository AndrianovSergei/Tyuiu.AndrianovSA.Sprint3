using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndrianovSA.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int k = startValue;

            do
            {
                multiplySeries *= Math.Pow(k / Math.Pow(Math.Sin(1), -7), -2);
                k++;
            }
            while (k <= stopValue);

            return Math.Round(multiplySeries, 3);
        }
    }
}