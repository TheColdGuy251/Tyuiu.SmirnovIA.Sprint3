using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint3.Task3.V20.Lib;

namespace Tyuiu.SmirnovIA.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string str = "gfft ntf f opf";
            char chr = 'f';
            int res = ds.GetCharCount(str, chr);
            Assert.AreEqual(5, res);
        }
    }
}
