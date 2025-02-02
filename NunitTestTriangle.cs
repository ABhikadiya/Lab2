﻿using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace lab2_abhikadiya
{

    [TestFixture]
    class NunitTestTriangle
    {
        [Test]
        public void TestGetHypotenuse1()
        {
            Triangle obj = new Triangle();
            double result = obj.GetHypotenuse(30, 50);
            Assert.AreEqual(58.31, result);

        }



        [Test]
        public void TestGetHypotenuse2()
        {
            Triangle obj = new Triangle();
            double result = obj.GetHypotenuse(10.80, 5.20);
            Assert.AreEqual(11.99, result);
        }

        [Test]
        public void TestGetArea1()
        {
            Triangle obj = new Triangle();
            double result = obj.GetArea(10, 20);
            Assert.AreEqual(100, result);
        }

        [Test]
        public void TestGetArea2()
        {
            Triangle obj = new Triangle();
            double result = obj.GetArea(23.60, 10.50);
            Assert.AreEqual(123.90, result);
        }

        [Test]
        public void TestAngle1()
        {
            Triangle obj = new Triangle();
            double result = obj.GetAngle(50, 80);
            Assert.AreEqual(50.00, result);
        }

        [Test]
        public void TestAngle2()
        {
            Triangle obj = new Triangle();
            double result = obj.GetAngle(40.54, 55.90);
            Assert.AreEqual(83.56, result);
        }
    }
}
