using Tyuiu.AntonovNS.Sprint3.Task1.V4.Lib;
namespace Tyuiu.AntonovNS.Sprint3.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1, stopValue = 10;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 1.55;
            Assert.AreEqual(wait, res);
        }
    }
}