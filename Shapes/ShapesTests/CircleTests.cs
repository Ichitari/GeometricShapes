using ShapesLibrary.Shapes;
using Xunit;
using FluentAssertions;
namespace ShapesTests;

public class CircleTests
{
    [Fact]
    public void CalculateArea_ValidArea_When_ValidRadius()
    {
        //Arrange
        double expected = 314.15926535897933;
        double radius = 10;
        IShape shape = new Circle(radius);

        //Act
        double actual = shape.CalculateArea();

        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void CircleInit_ArgumentOutOfRangeException_When_RadiusIsNegativeOrZero()
    {
        //Arrange
        double radius = -10;

        //Act
        var actual = () => new Circle(radius);

        //Assert 
        Assert.Throws<ArgumentOutOfRangeException>(actual);
    }
    [Theory]
    [InlineData(0.1)]
    [InlineData(0.00000001)]
    [InlineData(99999999)]
    public void CircleInit_NoException_When_RadiusIsPositive(double radius)
    {
        //Arrange & Act
        var act = () => new Circle(radius);

        //Assert
        act.Should().NotThrow();
    }

}