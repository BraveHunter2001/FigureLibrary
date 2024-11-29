namespace FigureLibrary;

public sealed class Triangle : Figure
{
    private double _a;
    private double _b;
    private double _c;

    public double A
    {
        get => _a;
        set
        {
            ValidateSide(value);
            _a = value;
        }
    }

    public double B
    {
        get => _b;
        set
        {
            ValidateSide(value);
            _b = value;
        }
    }

    public double C
    {
        get => _c;
        set
        {
            ValidateSide(value);
            _c = value;
        }
    }

    public override double Square => GetSquare();

    public bool IsRightTriangle(double epsilon = 0.00001)
    {
        double squareA = _a * _a;
        double squareB = _b * _b;
        double squareC = _c * _c;

        if (Math.Abs(squareA + squareB - squareC) <= epsilon)
            return true;

        if (Math.Abs(squareA + squareC - squareB) <= epsilon)
            return true;

        if (Math.Abs(squareB + squareC - squareA) <= epsilon)
            return true;

        return false;
    }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    private double GetSquare()
    {
        double semiperimeter = (_a + _b + _c) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - _a) * (semiperimeter - _b) * (semiperimeter - _c));
    }

    private void ValidateSide(double side)
    {
        if (side <= 0)
            throw new ArgumentException("The triangle side must be positive");
    }
}
