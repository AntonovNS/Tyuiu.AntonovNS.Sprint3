using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AntonovNS.Sprint3.Task6.V18.Lib
{
    public class DataService : ISprint3Task6V18
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int p = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                for (int d = 1; d <= k; d++)
                {
                    if (k % d == 0 && d < 10) 
                    {
                        p += d;
                    }
                }
            }
            return p;
        }
    }
}
