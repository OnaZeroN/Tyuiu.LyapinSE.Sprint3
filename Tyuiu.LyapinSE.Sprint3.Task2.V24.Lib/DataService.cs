using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LyapinSE.Sprint3.Task2.V24.Lib
{
    public class DataService : ISprint3Task2V24
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1;
            do
            {
                multSeries *= (Math.Pow(value, startValue) + 4) * Math.Cos(value);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(multSeries, 3);
        }
    }
}
