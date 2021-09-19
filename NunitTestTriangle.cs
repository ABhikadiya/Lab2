using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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

        [TestMethod]
        public void TestGetArea1()
        {
            Triangle obj = new Triangle();
            double result = obj.GetArea(10, 20);
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void TestGetArea2()
        {
            Triangle obj = new Triangle();
            double result = obj.GetArea(23.60, 10.50);
            Assert.AreEqual(123.90, result);
        }

        [TestMethod]
        public void TestAngle1()
        {
            Triangle obj = new Triangle();
            double result = obj.GetAngle(50, 80);
            Assert.AreEqual(50.00, result);
        }

        [TestMethod]
        public void TestAngle2()
        {
            Triangle obj = new Triangle();
            double result = obj.GetAngle(40.54, 55.90);
            Assert.AreEqual(83.56, result);
        }
    }
}
