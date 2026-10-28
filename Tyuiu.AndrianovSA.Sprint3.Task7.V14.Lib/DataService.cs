using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndrianovSA.Sprint3.Task7.V14.Lib
{
    public class DataService : ISprint3Task7V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue - startValue + 1];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x) + 1) == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double y = (2 * x - 4) + ((2 * x - 1) / (Math.Sin(x) + 1));
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}