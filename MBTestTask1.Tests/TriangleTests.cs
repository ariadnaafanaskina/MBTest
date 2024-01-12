using System;
using MBTestTask1.Shapes;

namespace MBTestTask1.Tests
{
    /// <summary>
    /// Тесты для треугольника
    /// </summary>
	public class TriangleTests
	{
        /// <summary>
        /// Тест для случаев: хотя бы одна сторона треугольника - отрицательная или все отрицательные
        /// </summary>
		[Fact]
		public void TringleSideIsNegativeTest()
		{
            var triangleOne = new Triangle(-7, 4, 5);
            var exOne = Assert.Throws<ArgumentOutOfRangeException>(() => triangleOne.Square);
            Assert.Equal("A side of the triangle is not allowed to be negative", exOne.ParamName);

            var triangleTwo = new Triangle(4, -7, 5);
            var exTwo = Assert.Throws<ArgumentOutOfRangeException>(() => triangleTwo.Square);
            Assert.Equal("A side of the triangle is not allowed to be negative", exTwo.ParamName);

            var triangleThree = new Triangle(4, 5, -7);
            var exThree = Assert.Throws<ArgumentOutOfRangeException>(() => triangleThree.Square);
            Assert.Equal("A side of the triangle is not allowed to be negative", exThree.ParamName);

            var triangleFour = new Triangle(-7, -7, -7);
            var exFour = Assert.Throws<ArgumentOutOfRangeException>(() => triangleFour.Square);
            Assert.Equal("A side of the triangle is not allowed to be negative", exFour.ParamName);
        }

        /// <summary>
        /// Тест для случая: неравенство треугольника не выполняется
        /// </summary>
		[Fact]
		public void TriangleInequalityIsNotReached()
		{
            var triangle = new Triangle(1, 0, 0);
            var ex = Assert.Throws<Exception>(() => triangle.Square);
            Assert.Equal("Triangle inequality is not reached", ex.Message);
        }

        /// <summary>
        /// Проверка корректности рассчёта площади треугольника по трём сторонам
        /// </summary>
		[Fact]
		public void CalculateTriangleSquare()
		{
            const double expectedResult = 13.416407864998739;

            var triangle = new Triangle(4, 7, 7);

            Assert.Equal(expectedResult, triangle.Square);
		}

        /// <summary>
        /// Проверка, что треугольник - прямоугольный
        /// </summary>
        [Fact]
        public void CheckRightTriangleTrueTest()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.True(triangle.IsRightTriangle());
        }

        /// <summary>
        /// Проверка корректности рассчёта площади прямоугольного треугольника по трём сторонам
        /// </summary>
        [Fact]
        public void CalculateRightTriangleSquare()
        {
            const double expectedResult = 6;

            var triangle = new Triangle(3, 4, 5);

            Assert.Equal(expectedResult, triangle.Square);
        }

        /// <summary>
        /// Проверка, что треугольник - не прямоугольный
        /// </summary>
        [Fact]
        public void CheckRightTriangleFalseTest()
        {
            var triangle = new Triangle(4, 7, 7);

            Assert.False(triangle.IsRightTriangle());
        }
    }
}

