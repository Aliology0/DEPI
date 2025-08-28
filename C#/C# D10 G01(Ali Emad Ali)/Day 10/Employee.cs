using System;

public class Employee : IComparable<Employee>, ICloneable
{
    // Auto Properties
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public object Clone()
    {
        return new Employee(Name, Salary);
    }

    public int CompareTo(Employee other)
    {
        if (other == null) return 1;
        return this.Salary.CompareTo(other.Salary);
    }

    public override string ToString()
    {
        return $"{Name} - {Salary}";
    }
}

public class Manager : Employee, IComparable<Manager>
{
    public Manager(string name, decimal salary) : base(name, salary) { }

    public int CompareTo(Manager other)
    {
        if (other == null) return 1;
        return this.Salary.CompareTo(other.Salary);
    }
}