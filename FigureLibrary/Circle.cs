namespace FigureLibrary;

public sealed class Circle : Figure
{
    private double _radius;
    private readonly double _square;

    public override double Square => Math.PI * _radius * _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            ValidateRadius(value);
            _radius = value;
        }
    }

    public Circle(double radius)
    {
        ValidateRadius(radius);
        _radius = radius;
    }

    private void ValidateRadius(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be positive");
    }
}
