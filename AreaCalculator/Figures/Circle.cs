namespace AreaCalculator.Figures
{
    using System;

    /// <summary>
    /// Circle.
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">Circle radius.</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets circle radius.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Calculating circle area.
        /// </summary>
        /// <returns>Circle area.</returns>
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
}
