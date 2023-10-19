using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint3.Task2.V7.Lib;

namespace Tyuiu.SmirnovIA.Sprint3.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            var res = ds.GetSumSeries(startValue, stopValue);
            Assert.AreEqual(81.083, res);
        }
    }
}
