using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SafronovVE.Sprint3.Task4.V17.Lib
{
    public class DataService : ISprint3Task4V17
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    break;
                }
                else
                {
                    res = res + Math.Cos(i) / Math.Sin(i);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
