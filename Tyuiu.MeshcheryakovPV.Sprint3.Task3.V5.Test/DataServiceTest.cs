using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint3.Task3.V5.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint3.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();

            string str = "fifa al fall";
            char chr = 'a';

            int res = ds.ReplaceCharInString(str, chr);

            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
