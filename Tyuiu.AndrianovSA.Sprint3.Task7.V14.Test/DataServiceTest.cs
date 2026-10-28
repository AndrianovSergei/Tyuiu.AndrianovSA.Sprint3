using Tyuiu.AndrianovSA.Sprint3.Task7.V14.Lib;

namespace Tyuiu.AndrianovSA.Sprint3.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = new double[stopValue - startValue + 1];
            res = ds.GetMassFunction(startValue, stopValue);

            double[] wait = new double[stopValue - startValue + 1];

            wait[0] = -19.62;
            wait[1] = -17.12;
            wait[2] = -18.15;
            wait[3] = -63.13;
            wait[4] = -24.92;
            wait[5] = -5.00;
            wait[6] = -1.46;
            wait[7] = 1.57;
            wait[8] = 6.38;
            wait[9] = 32.78;
            wait[10] = 225.11;

            CollectionAssert.AreEqual(wait, res);
        }
    }
}