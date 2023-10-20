using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint3.Task1.V21.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint3.Task1.V21.Test
{
    [TestClass]
    public class DataServicTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stoptValue = 12;

            double res = ds.GetMultiplySeries(value, startValue, stoptValue);

            double wait = 98.339;
            Assert.AreEqual(wait, res);


        }
    }
}
