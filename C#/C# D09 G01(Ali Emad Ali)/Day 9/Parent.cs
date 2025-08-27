using System;

class Parent
{
    public virtual int Salary { get; set; }
}

class Child : Parent
{
    public sealed override int Salary { get; set; }

    public void DisplaySalary()
    {
        Console.WriteLine($"Salary: {Salary}");
    }
}