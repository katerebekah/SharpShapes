using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var square = new Square();
            square.Top = 5;
            square.Right = 5;
            square.Bottom = 5;
            square.Left = 5;
            Assert.AreEqual(square.Area(), 25);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var square = new Square(5);
            Assert.AreEqual(square.Area(), 25);
        }
    }
}
