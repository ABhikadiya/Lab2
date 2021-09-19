﻿using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab2_abhikadiya
{

    [TestClass]
    class NunitTestTriangle
    {
        [TestMethod]
        public void TestGetHypotenuse1()
        {
            Triangle obj = new Triangle();
            double result = obj.GetHypotenuse(30, 50);
            Assert.AreEqual(58.31, result);
        }



        [TestMethod]
        public void TestGetHypotenuse2()
        {
            Triangle obj = new Triangle();
            double result = obj.GetHypotenuse(10.80, 5.20);
            Assert.AreEqual(11.99, result);
        }
    }
}
