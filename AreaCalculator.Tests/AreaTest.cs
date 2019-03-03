using System;
using AreaCalculator.Figures;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void ReturnRightTriangleArea()
        {
            var triangle = new Triangle(3,4,5);
            var s = triangle.CalculateArea();

            Assert.AreEqual(6, s);
        }

        [Test]
        public void ReturnRightCircleeArea()
        {
            var circle = new Circle(3);
            var s = circle.CalculateArea();

            Assert.AreEqual(28.274, Math.Round(s, 3));
        }
    }
}