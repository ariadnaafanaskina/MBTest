namespace MBTestTask1.Shapes;

/// <summary>
/// Базовый класс геометрической фигуры
/// </summary>
public abstract class BasicShape
{
    /// <summary>
    /// Площадь фигуры
    /// </summary>
    public double Square => CalculateSquare();

    /// <summary>
    /// Конструктор базового класса геометрической фигуры
    /// </summary>
    protected BasicShape()
    {

    }

    /// <summary>
    /// Посчитать площадь
    /// </summary>
    /// <returns></returns>
    protected abstract double CalculateSquare();

    /// <summary>
    /// Проверить исключения
    /// </summary>
    protected abstract void CheckForExceptions();
}

