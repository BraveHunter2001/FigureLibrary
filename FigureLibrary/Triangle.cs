namespace FigureLibrary;

// Question: Так как не было указано какого типа стороны треугольника, использовал double.
// Поэтому в функции проверки на прямоугольность треугольника, добавлена epsilone для сравнения double 
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
            ValidateSides(value, B, C);
            _a = value;
        }
    }

    public double B
    {
        get => _b;
        set
        {
            ValidateSides(value, A, C);
            _b = value;
        }
    }

    public double C
    {
        get => _c;
        set
        {
            ValidateSides(value, A, B);
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
        ValidateSides(a, b, c);

        _a = a;
        _b = b;
        _c = c;
    }

    private double GetSquare()
    {
        double semiperimeter = (_a + _b + _c) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - _a) * (semiperimeter - _b) * (semiperimeter - _c));
    }

    private void ValidateSides(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("The triangle side must be positive");

        if (a + b <= c || b + c <= a || c + a <= b)
            throw new ArgumentException("The sum of the lengths of any two sides of a triangle is greater than the length of the remaining side");
    }
}