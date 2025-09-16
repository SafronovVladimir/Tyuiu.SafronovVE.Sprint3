using Tyuiu.SafronovVE.Sprint3.Task0.V10.Lib;
namespace Tyuiu.SafronovVE.Sprint3.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            var wait = 0.033;

            Assert.AreEqual(wait, res);
        }
    }
}
