using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AntonovNS.Sprint3.Task5.V16.Lib
{
    public class DataService : ISprint3Task5V16
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double p = 1;
            for (int k = startValue1; k <= stopValue1; k++)
            {
                for (int i = startValue2; i <= stopValue2; i++)
                {
                    p = p + Math.Cos(i)+Math.Pow(2,2);
                }
            }
            return Math.Round(p,3);
        }
    }
}
