using Tyuiu.AntonovNS.Sprint3.Task6.V18.Lib;
namespace Tyuiu.AntonovNS.Sprint3.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 9, stopValue = 18;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 95;
            Assert.AreEqual(wait, res);
        }
    }
}