using System;
using RightTriangleLib;



using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RightAngleTests
{
    [TestClass]
    public class TriangleCheckerTests
    {


        [TestMethod]
        public void IsValidtestReturnsTrue()
        {
            
            triangle t = new triangle(3, 4, 5);
            TriangleChecker TC = new TriangleChecker(t);
            Assert.IsTrue(TC.IsValid());

        }
        [TestMethod]
        public void IsValidtestReturnsFalse()
        {

            triangle t = new triangle(1, 2, 3);
            TriangleChecker TC = new TriangleChecker(t);
            Assert.IsFalse(TC.IsValid());

        }
    }
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetAreaTestTrue()
        {
            triangle t = new triangle(3, 4, 5);
            Assert.AreEqual(t.GetArea(), (double)6);

        }
        [TestMethod]
        public void GetAreaTestFalse() 
        {
            triangle t = new triangle(2, 4, 5);
            Assert.AreNotEqual(t.GetArea(), (double)6);

        }

    }
}
