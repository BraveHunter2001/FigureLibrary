using FigureLibrary;

namespace FigureTests;

public class TriangleTest
{
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(4, 4, 6, false)]
    public void Triangle_IsRightTriangle(double a, double b, double c, bool expected)
    {
        //Arrange
        Triangle triangle = new(a, b, c);

        //Act
        bool isRightTriangle = triangle.IsRightTriangle();

        //Assert
        Assert.Equal(expected, isRightTriangle);
    }
}