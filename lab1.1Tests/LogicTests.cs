using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CountMoney1214Test()
        {
            var test = Logic.CountMoney(1214);
            Assert.AreEqual("12 рублей 14 копеек ", test);
        }

        [TestMethod()]
        public void CountMoney100Test()
        {
            var test = Logic.CountMoney(100);
            Assert.AreEqual("1 рубль ", test);
        }
        [TestMethod()]
        public void CountMoney81Test()
        {
            var test = Logic.CountMoney(81);
            Assert.AreEqual("81 копейка ", test);
        }
        [TestMethod()]
        public void CountMoney9999Test()
        {
            var test = Logic.CountMoney(9999);
            Assert.AreEqual("99 рублей 99 копеек ", test);
        }
        [TestMethod()]
        public void CountMoney242Test()
        {
            var test = Logic.CountMoney(242);
            Assert.AreEqual("2 рубля 42 копейки ", test);
        }
        [TestMethod()]
        public void CountMoney808Test()
        {
            var test = Logic.CountMoney(808);
            Assert.AreEqual("8 рублей 8 копеек ", test);
        }
    }
}