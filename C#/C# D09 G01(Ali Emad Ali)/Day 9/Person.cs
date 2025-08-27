using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Department: {Department}";
    }
}