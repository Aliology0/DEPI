using System;

namespace Day_6
{
    public struct Employee
    {
        private int Id;
        private string Name;
        private decimal Salary;

        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        // Getters
        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public decimal GetSalary()
        {
            return Salary;
        }

        //Setters
        public void SetId(int id)
        {
            Id = id;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetSalary(decimal salary)
        {
            if (salary < 0)
            {
                salary = 0;
            }
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nSalary: {Salary}\n=================================";
        }


    }
}