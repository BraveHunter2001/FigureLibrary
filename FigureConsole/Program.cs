using FigureLibrary;

namespace FigureConsole;

internal class Program
{
    static void Main(string[] args)
    {
        Figure figure1 = new Circle(1);
        Console.WriteLine($"Square {figure1.Square}");

        Console.WriteLine();

        Triangle t = new Triangle(3, 4, 5);
        string isRightStr = t.IsRightTriangle() ? "is Right" : "isnt right";
        Console.WriteLine($"Triangle {isRightStr}");

        Figure figure2 = t;
        Console.WriteLine($"Triangle {figure2.Square}");
    }
}