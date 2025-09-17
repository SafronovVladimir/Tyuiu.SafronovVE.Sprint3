using Tyuiu.SafronovVE.Sprint3.Task2.V11.Lib;
namespace Tyuiu.SafronovVE.Sprint3.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value;
            int startValue, stopValue;
            value = 0.5;
            startValue = 1;
            stopValue = 15;
            var res = ds.GetSumSeries(value, startValue, stopValue);
            var wait = 0.430;
            Assert.AreEqual(wait, res);
        }
    }
}
