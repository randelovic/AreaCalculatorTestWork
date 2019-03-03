namespace AreaCalculator.Figures
{
    using System;

    /// <summary>
    /// Triangle.
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="cathetus1">Triangle leg.</param>
        /// <param name="cathetus2">Triangle leg.</param>
        /// <param name="hypotenuse">Triangle hypotenuse.</param>
        public Triangle(double cathetus1, double cathetus2, double hypotenuse)
        {
            this.Cathetus1 = cathetus1;
            this.Cathetus2 = cathetus2;
            this.Hypotenuse = hypotenuse;
        }

        /// <summary>
        /// Gets or sets a leg of this triangle.
        /// </summary>
        public double Cathetus1 { get; set; }

        /// <summary>
        /// Gets or sets a leg of this triangle.
        /// </summary>
        public double Cathetus2 { get; set; }

        /// <summary>
        /// Gets or sets hypotenuse of this triangle.
        /// </summary>
        public double Hypotenuse { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this triangle is right.
        /// </summary>
        public bool IsRightTriangle => (Math.Pow(this.Cathetus1, 2) + Math.Pow(this.Cathetus2, 2)).Equals(Math.Pow(this.Hypotenuse, 2));

        /// <summary>
        /// Calculating triangle area by Heron's formula.
        /// </summary>
        /// <returns>Triangle area.</returns>
        public override double CalculateArea()
        {
            var p = (this.Cathetus1 + this.Cathetus2 + this.Hypotenuse) / 2;

            return Math.Sqrt(p * (p - this.Cathetus1) * (p - this.Cathetus2) * (p - this.Hypotenuse));
        }
    }
}
