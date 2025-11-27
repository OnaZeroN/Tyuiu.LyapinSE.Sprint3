using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LyapinSE.Sprint3.Task5.V27.Lib
{
    public class DataService : ISprint3Task5V27
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (int i = startValue1; i < stopValue1; i++)
            {
                for (int k = startValue2; k < stopValue2; k++)
                {
                    res += Math.Pow(k, x) / Math.Cos(k);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
