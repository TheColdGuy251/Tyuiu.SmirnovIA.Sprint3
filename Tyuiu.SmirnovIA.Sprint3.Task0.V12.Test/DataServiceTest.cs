using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint3.Task0.V12.Lib;

namespace Tyuiu.SmirnovIA.Sprint3.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 13;
            int value = 1;
            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(7.5, res);

        }
    }
}
