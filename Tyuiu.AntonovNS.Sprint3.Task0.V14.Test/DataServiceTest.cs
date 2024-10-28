using Tyuiu.AntonovNS.Sprint3.Task0.V14.Lib;
namespace Tyuiu.AntonovNS.Sprint3.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 2,startValue = 1, stopValue = 5;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 55;
            Assert.AreEqual(wait, res);
        }
    }
}