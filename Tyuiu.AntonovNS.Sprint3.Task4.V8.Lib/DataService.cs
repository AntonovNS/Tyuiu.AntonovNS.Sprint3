using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AntonovNS.Sprint3.Task4.V8.Lib
{
    public class DataService : ISprint3Task4V8
    {
        public double Calculate(int startValue, int stopValue)
        {
            double p = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                if (k == 0) 
                {
                    break;
                }
                p = p * ((k / Math.Sin(k)) + 0.5);
            }
            return Math.Round(p, 3);
        }
    }
}
