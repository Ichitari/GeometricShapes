namespace ShapesLibrary.Shapes;

public class Circle : IShape
{
    public double Radius { get; }
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(radius), "Радиус окружности должен быть положительной величиной");
        }
        Radius = radius;
    }
    /// <summary>
    /// Расчитать площадь
    /// </summary>
    /// <returns></returns>
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
