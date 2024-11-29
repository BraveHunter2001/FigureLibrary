namespace FigureLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            
        }
    }

    public abstract class Figure
    {
        public abstract double Square { get; }
    }

    public sealed class Circle : Figure
    {
        private readonly double _radius;
        public override double Square => Math.PI * _radius * _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive");

            _radius = radius;
        }
    }
}