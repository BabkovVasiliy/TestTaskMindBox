using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalc;
using System;

namespace Tests
{
    [TestClass]

    public class CircleTests
    {

        [TestMethod]
        public void Circle1()
        {
            Circle circle = new Circle(1);
            double expected = Math.PI;

            Assert.AreEqual(expected, circle.Area(), 0.0001, "Что-то пошло не так");
        }
        [TestMethod]
        public void Circle2()
        {
            Circle circle = new Circle(0);
            double expected = 0;

            Assert.AreEqual(expected, circle.Area(), 0.0001, "Что-то пошло не так");
        }
        [TestMethod]
        public void Circle3()
        {
            Circle circle = new Circle(2);
            double expected = 4 * Math.PI;

            Assert.AreEqual(expected, circle.Area(), 0.0001, "Что-то пошло не так");
        }
        [TestMethod]
        public void Circle4()
        {
            Circle circle = new Circle(-1);
            double expected = -1;

            Assert.AreEqual(expected, circle.Area(), 0.0001, "Что-то пошло не так");
        }
    }
    [TestClass]

    public class TriangleTests
    {
        [TestMethod]
        public void Triangle1()
        {
            Triangle triangle = new Triangle(0, 4, 5);
            double expected = -1;

            Assert.AreEqual(expected, triangle.Area(), 0.0001, "Что-то пошло не так");
        }

    
        [TestMethod]
        public void Triangle2()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6;

            Assert.AreEqual(expected, triangle.Area(), 0.0001, "Что-то пошло не так");
        }
        [TestMethod]
        public void Triangle3()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            double expected = 24;

            Assert.AreEqual(expected, triangle.Area(), 0.0001, "Что-то пошло не так");
        }
        [TestMethod]
        public void RightTriangle1()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool expected = true;

            Assert.AreEqual(expected, triangle.IsRightTriangle(), "Что-то пошло не так");
        }
        [TestMethod]
        public void RightTriangle2()
        {
            Triangle triangle = new Triangle(2, 2, 3);
            bool expected = false;

            Assert.AreEqual(expected, triangle.IsRightTriangle(), "Что-то пошло не так");
        }
        [TestMethod]
        public void RightTriangle3()
        {
            Triangle triangle = new Triangle(0, 2, 3);
            bool expected = false;

            Assert.AreEqual(expected, triangle.IsRightTriangle(), "Что-то пошло не так");
        }
    }
    [TestClass]

    public class ShapesTests
    {
        [TestMethod]
        public void Shape1()
        {
            Shape unknown = new Triangle(3, 4, 5);
            double expected = 6;

            Assert.AreEqual(expected, unknown.Area(), 0.0001, "Что-то пошло не так");
        
        }
        [TestMethod]
        public void Shape2()
        {
            Shape unknown = new Circle(1);
            double expected = Math.PI;

            Assert.AreEqual(expected, unknown.Area(), 0.0001, "Что-то пошло не так");

        }

    }
}