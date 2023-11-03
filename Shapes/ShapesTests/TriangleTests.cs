using ShapesLibrary.Shapes;
using Xunit;
namespace ShapesTests;

public class TriangleTests
{
    [Fact]
    public void CalculateArea_ValidArea_Where_ValidSides()
    {
        //Arrange
        double x1 = 13;
        double x2 = 14;
        double x3 = 15;
        double expected = 84;
        IShape shape = new Triangle(x1,x2,x3);

        //Act
        double actual = shape.CalculateArea();

        //Assert
        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(13,14,39)]
    [InlineData(13, 14, -15)]
    public void Triangle_ArgumentOutOfRangeException_When_IncorrectSides(double x1, double x2, double x3)
    {
        //Arrange & Act
        var actual = () => new Triangle(x1, x2, x3);
        //Assert
        Assert.Throws<ArgumentOutOfRangeException>(actual);
    }

    [Fact]
    public void IsRightAngle_False_When_ValidSides()
    {
        //Arrange
        double x1 = 13;
        double x2 = 14;
        double x3 = 15;
        bool expected = false;
        Triangle triangle = new Triangle(x1, x2, x3);

        //Act
        bool actual = triangle.IsRightAngle();

        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void IsRightAngle_True_When_ValidSides()
    {
        //Arrange
        double x1 = 13;
        double x2 = 12;
        double x3 = 5;
        bool expected = true;
        Triangle triangle = new Triangle(x1, x2, x3);

        //Act
        bool actual = triangle.IsRightAngle();

        //Assert
        Assert.Equal(expected, actual);
    }

}
