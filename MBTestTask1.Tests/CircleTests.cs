using MBTestTask1.Shapes;
namespace MBTestTask1.Tests;

/// <summary>
/// Тесты для круга
/// </summary>
public class CircleTests
{
    /// <summary>
    /// Тест для случая: радиус круга отрицательный
    /// </summary>
    [Fact]
    public void CircleRadiusIsNegativeTest()
    {
        var circle = new Circle(-7);
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => circle.Square);
        Assert.Equal("The radius of a circle is not allowed to be negative", ex.ParamName);
    }

    /// <summary>
    /// Проверка корректности расчёта площади круга по радиусу
    /// </summary>
    [Fact]
    public void CalculateCircleSquareTest()
    {
        const double expectedResult = 153.93804002589985;

        var circle = new Circle(7);

        Assert.Equal(expectedResult, circle.Square);
    }
}
