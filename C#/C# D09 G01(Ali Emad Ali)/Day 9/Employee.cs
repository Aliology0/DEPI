using System;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Employee other)
        {
            return this.Id == other.Id && this.Name == other.Name;
        }
        return false;
    }
}

class Employee2
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Department Department { get; set; }

    public override string ToString()
    {
        return $"Employee: {Name}, Department: {Department}";
    }
}