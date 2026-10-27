using Tyuiu.AndrianovSA.Sprint3.Task1.V22.Lib;

namespace Tyuiu.AndrianovSA.Sprint3.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 1.5;
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -11648.069;

            Assert.AreEqual(wait, res);
        }
    }
}