namespace ShapesLibrary.Shapes;

public class Circle : IShape
{
    public double Radius { get; }
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException("Радиус окружности должен быть положительной величиной");
        }
        Radius = radius;
    }
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
