using Tyuiu.AntonovNS.Sprint3.Task4.V8.Lib;
namespace Tyuiu.AntonovNS.Sprint3.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5, stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 2237.227;
            Assert.AreEqual(wait, res);
        }
    }
}