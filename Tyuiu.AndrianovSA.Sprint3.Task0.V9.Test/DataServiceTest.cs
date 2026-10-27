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
            double res = ds.GetSumSeries(x);

            // Ожидаемый результат для x = 0,5 при i от 1 до 15
            double wait = 0.415;

            Assert.AreEqual(wait, res);
        }
    }
}