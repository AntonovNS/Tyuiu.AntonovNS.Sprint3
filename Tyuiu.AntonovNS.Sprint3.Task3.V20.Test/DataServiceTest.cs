using Tyuiu.AntonovNS.Sprint3.Task3.V20.Lib;
namespace Tyuiu.AntonovNS.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string value = "gfft ntf f opf";
            char item = 'f';
            int wait = 5;
            int res = ds.GetCharCount(value, item);
            Assert.AreEqual(wait, res);
        }
    }
}