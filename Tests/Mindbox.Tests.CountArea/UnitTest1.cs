using MindBox.Libraries.CountArea.Figures;
using MindBox.Libraries.CountArea.Figures.Interfaces;
namespace Mindbox.Tests.CountArea
{
    public class Tests
    {
        [Test]
        public void WrongCircleTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-0.5));;
        }
        [Test]
        public void CircleAreaTest()
        {
            //Data
            var radius = 10;
            var circle = new Circle(radius);
            var expectedValue = Math.PI * Math.Pow(radius, 2);

            //Act
            var area = circle.GetArea();

            //Assert
            Assert.That(area, Is.EqualTo(expectedValue));
        }
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, 0)]
        public void WrongTriangleTest (double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }
        [Test]
        public void TriangleAreaTest()
        {
            // Data
            double a = 3, b = 4, c = 5;
            double expectedValue = 6;
            var triangle = new Triangle(a, b, c);

            // Act
            var area = triangle.GetArea();

            // Assert
            Assert.That(area, Is.EqualTo(expectedValue));
        }
        [Test]
        public void NotTriangleTest()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(1, 1, 4));
        }

        [TestCase(3, 4, 3, ExpectedResult = false)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        public bool RightTriangleTest(double a, double b, double c)
        {
            // Data
            var triangle = new Triangle(a, b, c);

            // Act
            var isRight = triangle.IsRightTriangle();

            // Assert
            return isRight;
        }
        [Test]
        public void FigureAreaTest1()
        {
            // Data
            double a = 3, b = 4, c = 5;
            double expectedValue = 6;
            var triangle = new Triangle(a, b, c);
            Figure fig = new Figure(triangle);

            // Act
            var area = fig.GetArea();

            // Assert
            Assert.That(area, Is.EqualTo(expectedValue));
        }
        [Test]
        public void FigureAreaTest2()
        {
            // Data
            var radius = 10;
            var circle = new Circle(radius);
            var expectedValue = Math.PI * Math.Pow(radius, 2);
            Figure fig = new Figure(circle);

            // Act
            var area = fig.GetArea();

            // Assert
            Assert.That(area, Is.EqualTo(expectedValue));
        }
    }
}