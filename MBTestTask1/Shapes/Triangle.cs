using System;
namespace MBTestTask1.Shapes
{
	/// <summary>
	/// Треугольник
	/// </summary>
	public class Triangle : BasicShape
	{
		/// <summary>
		/// Первая сторона треугольника
		/// </summary>
		public double FirstSide { get; set; }

		/// <summary>
		/// Вторая строна треугольника
		/// </summary>
		public double SecondSide { get; set; }

		/// <summary>
		/// Третья сторона треугольника
		/// </summary>
		public double ThirdSide { get; set; }

        /// <summary>
        /// Конструктор класса треугольника
        /// </summary>
        /// <param name="firstSide">Первая сторона треугольника</param>
        /// <param name="secondSide">Вторая сторона треугольника</param>
        /// <param name="thirdSide">Третья сторона треугольника</param>
        public Triangle(double firstSide, double secondSide, double thirdSide)
		{
			FirstSide = firstSide;
			SecondSide = secondSide;
			ThirdSide = thirdSide;
		}

		/// <summary>
		/// Посчитать площадь треугольника по трём сторонам
		/// </summary>
		/// <returns>Площадь треугольника</returns>
        protected override double CalculateSquare()
        {
			CheckForExceptions();

			var halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

			return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide)
				* (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));
        }

		/// <summary>
		/// Проверить, что треугольник является прямоугольным
		/// </summary>
		/// <returns>True/False</returns>
		public bool IsRightTriangle()
		{
			CheckForExceptions();

			return (Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) == Math.Pow(ThirdSide, 2)) ||
				(Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2) == Math.Pow(SecondSide, 2)) ||
				(Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2) == Math.Pow(FirstSide, 2));
		}

		/// <summary>
		/// Проверить исключения
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Если значение хотя бы одной стороны отрицательное</exception>
		/// <exception cref="Exception">Если неравенство треугольника не выполняется</exception>
		protected override void CheckForExceptions()
		{
            if (FirstSide < 0 || SecondSide < 0 || ThirdSide < 0)
				throw new ArgumentOutOfRangeException("A side of the triangle is not allowed to be negative");

			if (FirstSide + SecondSide < ThirdSide ||
					FirstSide + ThirdSide < SecondSide ||
					SecondSide + ThirdSide < FirstSide)
				throw new Exception("Triangle inequality is not reached");
		}

    }
}

