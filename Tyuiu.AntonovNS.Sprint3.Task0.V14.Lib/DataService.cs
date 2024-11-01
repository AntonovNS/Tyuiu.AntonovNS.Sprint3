﻿using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AntonovNS.Sprint3.Task0.V14.Lib
{
    public class DataService : ISprint3Task0V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                p = p * (Math.Pow(1 / (Math.Pow(k, value)), -1));
            }
            return p;
        }
    }
}
