using FigureLibrary;

namespace FigureTests;

public class FigureTest
{
    public static List<object[]> TestFiguresData =
    [
        new object[] { new Circle(1), Math.PI },
        new object[] { new Triangle(14, 13, 15), 84 }
    ];

    [Theory]
    [MemberData(nameof(TestFiguresData))]
    public void Figure_Square(Figure figure, double expectedSquare)
    {
        Assert.Equal(expectedSquare, figure.Square);
    }
}