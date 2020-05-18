using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalc;
using System;

namespace Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void ValidCircle()
        {
            Circle circle = new Circle(2);
            double expected = 4 * Math.PI;

            Assert.IsTrue(circle.IsValid());
            Assert.AreEqual(expected, circle.Area(), 0.0001, "Что-то пошло не так");
        }

        [TestMethod]
        public void InvalidCircle()
        {
            Circle circle = new Circle(-1);
            double expected = -1;

            Assert.IsFalse(circle.IsValid());
            Assert.AreEqual(expected, circle.Area(), 0.0001, "Что-то пошло не так");
        }

        [TestMethod]
        public void Circle1Unit()
        {
            Circle circle = new Circle(1);
            double expected = Math.PI;

            Assert.IsTrue(circle.IsValid());
            Assert.AreEqual(expected, circle.Area(), 0.0001, "Что-то пошло не так");
        }

        [TestMethod]
        public void CircleButDot()
        {
            Circle circle = new Circle(0);
            double expected = 0;

            Assert.IsTrue(circle.IsValid());
            Assert.AreEqual(expected, circle.Area(), 0.0001, "Что-то пошло не так");
        }

    }

    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void InvalidTriangleWithZeroSide()
        {
            Triangle triangle = new Triangle(0, 4, 5);
            double expected = -1;

            Assert.IsFalse(triangle.IsValid());
            Assert.AreEqual(expected, triangle.Area(), 0.0001, "Что-то пошло не так");
        }

        [TestMethod]
        public void InvalidTriangleWithAllNonZeroSides()
        {
            Triangle triangle = new Triangle(2, 2, 5);
            bool expected = false;

            Assert.IsFalse(triangle.IsValid());
            Assert.AreEqual(expected, triangle.IsRightTriangle(), "Что-то пошло не так");
        }

        [TestMethod]
        public void ValidTriangleNonRightAngle()
        {
            Triangle triangle = new Triangle(2, 2, 3);
            double area = 1.9843;

            Assert.IsFalse(triangle.IsRightTriangle());
            Assert.AreEqual(area, triangle.Area(), 0.0001, "Что-то пошло не так");
        }

        [TestMethod]
        public void ValidRightTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6;

            Assert.IsTrue(triangle.IsValid());
            Assert.AreEqual(expected, triangle.Area(), 0.0001, "Что-то пошло не так");
            Assert.IsTrue(triangle.IsRightTriangle());
        }
    }

    [TestClass]
    public class ShapesTests
    {
        [TestMethod]
        public void AbstractTriangle()
        {
            Shape unknown = new Triangle(3, 4, 5);
            double expected = 6;

            Assert.AreEqual(expected, unknown.Area(), 0.0001, "Что-то пошло не так");
        }

        [TestMethod]
        public void AbstractCircle()
        {
            Shape unknown = new Circle(1);
            double expected = Math.PI;

            Assert.AreEqual(expected, unknown.Area(), 0.0001, "Что-то пошло не так");
        }
    }
}