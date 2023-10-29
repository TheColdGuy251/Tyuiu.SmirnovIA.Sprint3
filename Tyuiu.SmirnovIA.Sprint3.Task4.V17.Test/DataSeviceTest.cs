using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovIA.Sprint3.Task4.V17.Lib;

namespace Tyuiu.SmirnovIA.Sprint3.Task4.V17.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(0.527, res);
        }
    }
}
