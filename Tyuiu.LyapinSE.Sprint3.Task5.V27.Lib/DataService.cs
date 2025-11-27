using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LyapinSE.Sprint3.Task5.V27.Lib
{
    public class DataService : ISprint3Task4V27
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                for (int k = startValue; k < stopValue; k++)
                {
                    res += Math.Pow(k, 2) / Math.Cos(k);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
