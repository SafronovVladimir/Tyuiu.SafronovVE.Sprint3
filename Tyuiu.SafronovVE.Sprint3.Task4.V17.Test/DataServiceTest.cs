using Tyuiu.SafronovVE.Sprint3.Task4.V17.Lib;
namespace Tyuiu.SafronovVE.Sprint3.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            var res = ds.Calculate(startValue, stopValue);
            var wait = 0.527;
            Assert.AreEqual(wait, res);
        }
    }
}
