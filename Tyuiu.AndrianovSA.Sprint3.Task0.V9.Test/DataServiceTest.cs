using Tyuiu.AndrianovSA.Sprint3.Task0.V9.Lib;

namespace Tyuiu.AndrianovSA.Sprint3.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double x = 0.5;
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(x, startValue, stopValue);
            double wait = 0.415;

            Assert.AreEqual(wait, res);
        }
    }
}