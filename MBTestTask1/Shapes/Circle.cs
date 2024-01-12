namespace MBTestTask1.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
	public class Circle : BasicShape
	{
        /// <summary>
        /// Радиус круга
        /// </summary>
		public double Radius { get; set; }

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Посчитать площадь круга по радиусу
        /// </summary>
        /// <returns>Площадь круга</returns>
        protected override double CalculateSquare()
        {
            CheckForExceptions();

			return Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Проверить исключения
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Если радиус круга — отрицательный</exception>
        protected override void CheckForExceptions()
        {
            if (Radius < 0)
                throw new ArgumentOutOfRangeException("The radius of a circle is not allowed to be negative");
        }
    }
}

