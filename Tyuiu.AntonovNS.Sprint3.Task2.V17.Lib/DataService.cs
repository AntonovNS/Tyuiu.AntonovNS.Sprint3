using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AntonovNS.Sprint3.Task2.V17.Lib
{
    public class DataService : ISprint3Task2V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double p = 0;
            for (int k = startValue; k <= stopValue; k++)
            {

                p = p + Math.Pow((1/(Math.Cos(k)+2)),2);
            }
            return Math.Round(p,3);
        }
    }
}
