using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    internal class task
    {
        static void Main(string[] args)
        {
            List<IEmployee> employees = new List<IEmployee>
            {
                new Manager { Name = "Alice", Salary = 5000 },
                new Developer { Name = "Bob", Salary = 4000 },
                new Manager { Name = "Charlie", Salary = 6000 },
                new Developer { Name = "Diana", Salary = 4500 },
            };

            float totalSalary = 0;

            foreach(IEmployee employee in employees)
            {
                totalSalary += employee.Salary + employee.CalculateBonus();
            }
            Console.WriteLine(totalSalary);
        }
    }

    interface IEmployee
    {
        string Name { get; }
        float Salary { get; }
        float CalculateBonus();
    }

    class Manager : IEmployee
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public float CalculateBonus() => Salary * 0.2f;
    }

    class Developer : IEmployee
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public float CalculateBonus() => Salary * 0.1f;
    }
}
