using System;

public class Shape : IComparable<Shape>
{
    private string name;
    private double area;

    #region Properties
    public string Name
    {
        get => name;
        set => name = value;
    }
    public double Area
    {
        get => area;
        set => area = value;
    }
    #endregion

    public Shape(string _name, double _area)
    {
        name = _name;
        area = _area;
    }

    public int CompareTo(Shape? other)
    {
        if (other == null) return 1;
        return area.CompareTo(other.area);
    }

    public override string ToString()
    {
        return $"{name} (Area = {area})";
    }
}