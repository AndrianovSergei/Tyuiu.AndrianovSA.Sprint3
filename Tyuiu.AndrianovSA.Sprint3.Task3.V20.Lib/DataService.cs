using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndrianovSA.Sprint3.Task3.V20.Lib
{
    public class DataService : ISprint3Task3V20
    {
        public int GetCharCount(string value, char item)
        {
            int count = 0;
            foreach (char ch in value)
            {
                if (ch == item)
                {
                    count++;
                }
            }
            return count;
        }
    }
}