using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;


namespace Shape.Test
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void Round_Area()
        {
            Round circle =new Round(2);
            Assert.AreEqual(circle.Area, System.Math.PI);

        }
        [TestMethod]
        public void IsTriangle_Test()
        {
            Triangle tri = new Triangle(1,2,7);
            Assert.AreEqual(tri.IsTriangle(), false);

        }
        [TestMethod]
        public void IsRightTriangle_Test()
        {
            Triangle tri = new Triangle(3, 4, 5);
            Assert.IsTrue(tri.IsRightTriangle());
      
    }
}
