using Tyuiu.AntonovNS.Sprint3.Task2.V17.Lib;
namespace Tyuiu.AntonovNS.Sprint3.Task2.V17.Test
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
            double wait = 4.4;
            Assert.AreEqual(wait, res);
        }
    }
}