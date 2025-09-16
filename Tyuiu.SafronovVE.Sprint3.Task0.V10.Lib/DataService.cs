using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SafronovVE.Sprint3.Task0.V10.Lib
{
    public class DataService : ISprint3Task0V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                multSeries = multSeries * Math.Pow(300 / (i + Math.Pow(value, i)), i);
            }
            return Math.Round(multSeries, 3);
        }
    }
}
