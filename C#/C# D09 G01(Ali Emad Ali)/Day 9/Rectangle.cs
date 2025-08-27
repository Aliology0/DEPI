using System;

struct Rectangle
{
    public int Length { get; set; }
    public int Width { get; set; }

    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }

    public override string ToString()
    {
        return $"Length = {Length}, Width = {Width}";
    }
}
