using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndrianovSA.Sprint3.Task6.V23.Lib
{
    public class DataService : ISprint3Task6V23
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0 && d < 11)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}