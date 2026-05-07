namespace abstracts2
{
    internal class task1
    {
        static void Main1(string[] args)
        {
            Employee e1 = new FixedSalaryEmployee("Вася", 10000);
            HourlyEmployee e2 = new HourlyEmployee("Влад", 5000, 100);

            List<Employee> employees = new List<Employee>() { e1, e2 };

            foreach (Employee employee in employees)
            {
                employee.ShowInfo();
            }
        }

        abstract class Employee
        {
            public string Name { get; set; }

            public Employee(string name)
            {
                Name = name;
            }

            public abstract double CalculateMonthlySalary();

            public virtual string GetJobInfo() => "сотрудник";

            public void ShowInfo()
            {
                Console.WriteLine($"{Name} {GetJobInfo()}: {CalculateMonthlySalary()}руб");
            }
        }

        class FixedSalaryEmployee : Employee
        {
            public double FixedSalary { get; set; }

            public FixedSalaryEmployee(string name, double fixedSalary) : base(name)
            {
                FixedSalary = fixedSalary;
            }

            public override double CalculateMonthlySalary() => FixedSalary;

            public override string GetJobInfo() => "Сотрудник с фиксированным окладом";
        }

        class HourlyEmployee : Employee
        {
            public double HourSalary { get; set; }
            public double HourCount { get; set; }

            public HourlyEmployee(string name, double hourSalary, double hourCount) : base(name)
            {
                HourSalary = hourSalary;
                HourCount = hourCount;
            }

            public override double CalculateMonthlySalary() => HourSalary * HourCount;

            public override string GetJobInfo() => "Сотрудник с часовой оплатой";

        }
    }

}
