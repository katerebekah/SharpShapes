using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class QuadrilateralTests
    {
        public class QuadTestClass : Quadrilateral
        {
            public override float Area ()
        {
            throw new NotImplementedException();
        }
        }
    [TestMethod]
    public void TestQuadrilateralCanComputePerimeter()
    {
        Quadrilateral myQuadrilateral = new Quadrilateral();
        myQuadrilateral.Top = 2;
        myQuadrilateral.Right = 4;
        myQuadrilateral.Bottom = 99;
        myQuadrilateral.Left = 6;
        Assert.AreEqual(myQuadrilateral.Perimeter(), 111);

    }
        [TestMethod]
        public void QuadrilateralCanGetSideLength()
        {
            Quadrilateral myQuadrilateral = new Quadrilateral();
            myQuadrilateral.Top = 2;
            Assert.AreEqual(myQuadrilateral.Top, 2);

        }

    }
}