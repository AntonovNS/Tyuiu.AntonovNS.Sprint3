using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AntonovNS.Sprint3.Task7.V4.Lib
{
    public class DataService : ISprint3Task7V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] arr;
            int len = (stopValue - startValue) + 1;
            arr = new double[len];
            double t;
            int count=0;
            for (int x = startValue; x <= stopValue; x++) 
            {
                if (Math.Cos(x) + x == 0) 
                {
                    arr[x] = 0;
                }
                t = Math.Round(((2 * x + 6) / (Math.Cos(x) + x)) - 3,2);
                arr[count] = t;
                count++;
            }
        return arr;
        }
    }
}
