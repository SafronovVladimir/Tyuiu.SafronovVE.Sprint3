﻿using Tyuiu.SafronovVE.Sprint3.Task5.V27.Lib;
namespace Tyuiu.SafronovVE.Sprint3.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x, startValue1, startValue2, stopValue1, stopValue2;
            x = 2;
            startValue1 = 1;
            startValue2 = 1;
            stopValue1 = 3;
            stopValue2 = 10;
            var res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            var wait = -1495.954;
            Assert.AreEqual(wait, res);
        }
    }
}
