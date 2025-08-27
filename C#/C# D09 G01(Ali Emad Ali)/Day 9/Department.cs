using System;

class Department
{
    public int DeptId { get; set; }
    public string DeptName { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Department other)
        {
            return this.DeptId == other.DeptId && this.DeptName == other.DeptName;
        }
        return false;
    }

    public override string ToString()
    {
        return $"{DeptName} (ID: {DeptId})";
    }
}