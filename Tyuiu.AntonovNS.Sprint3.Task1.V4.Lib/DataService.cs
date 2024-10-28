﻿using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AntonovNS.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double p = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                p = p + (Math.Pow(1 / k , 2));
            }
            return p;
        }
    }
}
