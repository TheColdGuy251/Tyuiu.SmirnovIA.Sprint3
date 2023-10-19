using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint3.Task1.V7.Lib;

namespace Tyuiu.SmirnovIA.Sprint3.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 9;
            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(-0.93, res);
        }
    }
}
