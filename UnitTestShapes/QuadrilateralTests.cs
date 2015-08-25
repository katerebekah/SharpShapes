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
        QuadTestClass myQuadrilateral = new QuadTestClass();
        myQuadrilateral.Side1 = 2;
        myQuadrilateral.Side2 = 4;
        myQuadrilateral.Side3 = 99;
        myQuadrilateral.Side4 = 6;
        Assert.AreEqual(myQuadrilateral.Perimeter(), 111);

    }
    }
}