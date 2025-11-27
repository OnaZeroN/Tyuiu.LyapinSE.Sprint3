using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LyapinSE.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint3Task0V25
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                sumSeries += Math.Pow(4 / (1 + Math.Pow(value, i)), i);
            }
            return sumSeries;
        }
    }
}
