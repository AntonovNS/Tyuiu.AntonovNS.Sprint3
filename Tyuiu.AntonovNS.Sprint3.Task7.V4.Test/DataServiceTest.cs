using Tyuiu.AntonovNS.Sprint3.Task7.V4.Lib;
namespace Tyuiu.AntonovNS.Sprint3.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5, stopValue = 5;
            double[] wait;
            int len = stopValue - startValue + 1;
            wait = new double[len];
            wait[0] = -2.15;
            wait[1] = -2.57;
            wait[2] = -3;
            wait[3] = -3.83;
            wait[4] = -11.7;
            wait[5] = 3;
            wait[6] = 2.19;
            wait[7] = 3.31;
            wait[8] = 2.97;
            wait[9] = 1.18;
            wait[10] = 0.03;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait,res);
        }
    }
}