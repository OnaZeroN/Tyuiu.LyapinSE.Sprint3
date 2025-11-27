using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LyapinSE.Sprint3.Task7.V7.Lib
{
    public class DataService : ISprint3Task7V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[(stopValue - startValue) + 1];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2 == 0)
                {
                    valueArray[index] = 0;
                    continue;
                }
                valueArray[index] = Math.Round(Math.Cos(x) + (Math.Cos(x) / x + 2) - (3 * x), 2);
                index++;
            }
            return valueArray;
        }
    }
}
