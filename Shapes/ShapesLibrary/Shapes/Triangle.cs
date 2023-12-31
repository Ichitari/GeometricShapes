﻿namespace ShapesLibrary.Shapes;

public class Triangle : IShape
{
    /// <summary>
    /// Большая сторона
    /// </summary>
    public double SideAB { get; }
    public double SideBC { get; }
    public double SideAC { get; }
    public Triangle(double x1, double x2, double x3)
    {
        if (x1 <= 0 || x2 <= 0 || x3 <= 0)
        {
            throw new ArgumentOutOfRangeException("x-params","Сторона треугольника должна быть положительной величиной");
        }
        if (x1 > x2 && x1 > x3)
        {
            SideAB = x1;
            SideBC = x2;
            SideAC = x3;
        }
        else if (x2 > x1 && x2 > x3)
        {
            SideAB = x2;
            SideBC = x1;
            SideAC = x3;
        }
        else
        {
            SideAB = x3;
            SideBC = x1;
            SideAC = x2;
        }
        if (SideAB >= SideAC + SideBC)
        {
            throw new ArgumentOutOfRangeException(nameof(SideAB),"Большая сторона треугольника должна быть меньше суммы двух других его сторон");
        }
    }
    /// <summary>
    /// Расчитать площадь
    /// </summary>
    /// <returns></returns>
    public double CalculateArea()
    {
        double semiperimeter = (SideAB + SideBC + SideAC) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - SideAB) * (semiperimeter - SideBC) * (semiperimeter - SideAC));
    }
    /// <summary>
    /// Наличие прямого угла
    /// </summary>
    /// <returns></returns>
    public bool IsRightAngle()
    {
        return Math.Pow(SideAB, 2) == Math.Pow(SideBC, 2) + Math.Pow(SideAC, 2);
    }
}
