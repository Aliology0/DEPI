using System;

public abstract class GeometricShape
{
    public double Dimension1 { get; set; }
    public double Dimension2 { get; set; }

    protected GeometricShape(double d1, double d2)
    {
        Dimension1 = d1;
        Dimension2 = d2;
    }

    public abstract double CalculateArea();
    public abstract double Perimeter { get; }
    public override string ToString()
    {
        return $"{this.GetType().Name} => Area: {CalculateArea()}, Perimeter: {Perimeter}";
    }
}

// Triangle class
public class Triangle : GeometricShape
{
    public Triangle(double baseLength, double height) : base(baseLength, height) { }

    public override double CalculateArea()
    {
        return 0.5 * Dimension1 * Dimension2;
    }

    public override double Perimeter
    {
        get
        {
            double hypotenuse = Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2);
            return Dimension1 + Dimension2 + hypotenuse;
        }
    }
}

// Rectangle class
public class Rectangle : GeometricShape
{
    public Rectangle(double length, double width) : base(length, width) { }

    public override double CalculateArea()
    {
        return Dimension1 * Dimension2;
    }

    public override double Perimeter
    {
        get { return 2 * (Dimension1 + Dimension2); }
    }
}
// Circle class
public class Circle : GeometricShape
{
    public Circle(double radius) : base(radius, 0) { }

    public override double CalculateArea()
    {
        return Math.PI * Dimension1 * Dimension1;
    }

    public override double Perimeter
    {
        get { return 2 * Math.PI * Dimension1; }
    }
}

// Factory class
public static class ShapeFactory
{
    public static GeometricShape CreateShape(string shapeType, double dim1, double dim2)
    {
        switch (shapeType.ToLower())
        {
            case "triangle":
                return new Triangle(dim1, dim2);
            case "rectangle":
                return new Rectangle(dim1, dim2);
            case "circle":
                return new Circle(dim1);
            default:
                throw new ArgumentException("Invalid shape type.");
        }
    }
}