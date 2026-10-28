using Tyuiu.AndrianovSA.Sprint3.Task3.V20.Lib;

namespace Tyuiu.AndrianovSA.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string str = "gfft ntf f opf";
            char ch = 'f';

            int res = ds.GetCharCount(str, ch);
            int wait = 5;

            Assert.AreEqual(wait, res);
        }
    }
}