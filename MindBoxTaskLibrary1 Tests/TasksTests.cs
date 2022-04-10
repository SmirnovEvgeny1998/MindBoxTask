using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MindBoxTaskLibrary1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            //arrange
            double x = 2;
            double expected = 12.5663706143592;

            //act
            Tasks c = new Tasks();
            double actual = c.CalculateCircleArea(x);

            //assert
            Assert.AreEqual(expected, actual, 0.0000000000001);
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            //arrange
            double x = 2;
            double y = 3;
            double z = 4;
            double expected = 2.90473750965556;

            //act
            Tasks c = new Tasks();
            double actual = c.CalculateTriangleArea(x, y, z);

            //assert
            Assert.AreEqual(expected, actual, 0.0000000000001);
        }
        [TestMethod]
        public void RingAreaTest()
        {
            //arrange
            double x = 4;
            double y = 3;
            double expected = 21.9911485751286;

            //act
            Tasks c = new Tasks();
            double actual = c.CalculateRingArea(x, y);

            //assert
            Assert.AreEqual(expected, actual, 0.0000000000001);
        }
        [TestMethod]
        public void QuadrilateralAreaTest()
        {
            //arrange
            double x = 7;
            double y = 6;
            double z = 85;
            double expected = 20.9200886599267;

            //act
            Tasks c = new Tasks();
            double actual = c.CalculateQuadrilateralArea(x, y, z);

            //assert
            Assert.AreEqual(expected, actual, 0.0000000000001);
        }
        [TestMethod]
        public void EllipseAreaTest()
        {
            //arrange
            double x = 2;
            double y = 4;
            double expected = 25.1327412287183;

            //act
            Tasks c = new Tasks();
            double actual = c.CalculateEllipseArea(x, y);

            //assert
            Assert.AreEqual(expected, actual, 0.0000000000001);
        }
        [TestMethod]
        public void RegularPolygonAreaTest()
        {
            //arrange
            double x = 7;
            double y = 3;
            double expected = 32.7052119960143;

            //act
            Tasks c = new Tasks();
            double actual = c.CalculateRegularPolygonArea(x, y);

            //assert
            Assert.AreEqual(expected, actual, 0.0000000000001);
        }
        [TestMethod]
        public void RegularAnyFigureAreaTest()
        {
            //arrange
            double x = -4;
            double y = 0;
            double z = -4;
            double a = 2;
            double b = 0;
            double c = 4;
            double d = 0;
            double e = 0;
            double expected = 12;

            //act
            Tasks s = new Tasks();
            double actual = s.CalculateAnyFigureArea(x, y, z, a, b, c, d, e);

            //assert
            Assert.AreEqual(expected, actual, 0.0000000000001);
        }
        [TestMethod]
        public void IsTriangleRightTest()
        {
            //arrange
            double x = 4;
            double y = 4;
            double z = 5.65685;
            bool expected = true;

            //act
            Tasks c = new Tasks();
            bool actual = c.IsTriangleRight(x, y, z);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
