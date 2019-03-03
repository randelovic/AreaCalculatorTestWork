namespace AreaCalculator.Figures
{
    /// <summary>
    /// Abstract figure.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Triangle creation.
        /// </summary>
        /// <param name="cathetus1">Triangle leg.</param>
        /// <param name="cathetus2">Triangle leg.</param>
        /// <param name="hypotenuse">Triangle hypotenuse.</param>
        /// <returns></returns>
        public static Figure Create(double cathetus1, double cathetus2, double hypotenuse)
        {
            return new Triangle(cathetus1, cathetus2, hypotenuse);
        }

        /// <summary>
        /// Circle creation.
        /// </summary>
        /// <param name="radius">Circle radius.</param>
        /// <returns></returns>
        public static Figure Create(double radius)
        {
            return new Circle(radius);
        }

        /// <summary>
        /// Area calculating.
        /// </summary>
        /// <returns>Figure area.</returns>
        public abstract double CalculateArea();
    }
}
