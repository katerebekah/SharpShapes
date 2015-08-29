using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void DefaultContructorCanComputeArea()
        {
            var rectangle = new Rectangle();
            rectangle.Top = 4;
            rectangle.Right = 3;
            rectangle.Bottom = 4;
            rectangle.Left = 3;
            Assert.AreEqual(rectangle.Area(), 12);
        }
        [TestMethod]
        public void RectangleContructorCanComputeArea()
        {
            var rectangle = new Rectangle(3, 4);
            Assert.AreEqual(rectangle.Area(), 12);
        }
    }
}
