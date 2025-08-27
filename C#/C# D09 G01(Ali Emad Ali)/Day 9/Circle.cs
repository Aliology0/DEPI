using System;

struct CircleStruct
{
    public double Radius { get; set; }
    public string Color { get; set; }

    public CircleStruct(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    public override bool Equals(object obj)
    {
        if (obj is CircleStruct other)
        {
            return this.Radius == other.Radius && this.Color == other.Color;
        }
        return false;
    }
}

class CircleClass
{
    public double Radius { get; set; }
    public string Color { get; set; }

    public CircleClass(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    public override bool Equals(object obj)
    {
        if (obj is CircleClass other)
        {
            return this.Radius == other.Radius && this.Color == other.Color;
        }
        return false;
    }
}