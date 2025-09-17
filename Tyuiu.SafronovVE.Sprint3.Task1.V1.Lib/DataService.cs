using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SafronovVE.Sprint3.Task1.V1.Lib
{
    public class DataService : ISprint3Task1V1
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiplySeries = 1;
            while (startValue <= stopValue)
            {
                multiplySeries = multiplySeries * Math.Pow(startValue, 2) / Math.Pow(3, 2);
                startValue++;
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}
