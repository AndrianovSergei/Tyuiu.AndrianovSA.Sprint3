namespace Tyuiu.AndrianovSA.Sprint3.Task0.V9.Lib
{
    public class DataService
    {
        public double GetSumSeries(double x)
        {
            double sumSeries = 0;
            int startValue = 1;
            int stopValue = 15;

            for (int i = startValue; i <= stopValue; i++)
            {
                sumSeries += Math.Pow((1.0 / (3.0 + Math.Pow(x, i))), i);
            }

            return Math.Round(sumSeries, 3);
        }
    }
}