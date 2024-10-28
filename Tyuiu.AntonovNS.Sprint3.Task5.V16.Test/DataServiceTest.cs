using Tyuiu.AntonovNS.Sprint3.Task5.V16.Lib;
namespace Tyuiu.AntonovNS.Sprint3.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int startValue1 = 1, stopValue1 = 3, startValue2 = 1, stopValue2 = 10;
            double res = ds.GetSumSumSeries(2,startValue1, stopValue1, startValue2, stopValue2);
            double wait = 31.458;
            Assert.AreEqual(wait, res);
        }
    }
}