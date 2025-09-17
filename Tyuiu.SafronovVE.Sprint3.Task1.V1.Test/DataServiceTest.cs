using Tyuiu.SafronovVE.Sprint3.Task1.V1.Lib;
namespace Tyuiu.SafronovVE.Sprint3.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            int startValue, stopValue;
            startValue = 1;
            stopValue = 7;
            DataService ds = new DataService();
            var res = ds.GetMultiplySeries(startValue, stopValue);
            var wait = 5.311;
            Assert.AreEqual(wait, res);
        }
    }
}
