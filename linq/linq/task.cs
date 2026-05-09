using System;
using System.Collections.Generic;
using System.Text;

namespace linq
{
    internal class task
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Vlad", 30, "Programmer", 1000),
                new Worker("Ira", 80, "Designer", 1200),
                new Worker("Vova",50, "Programmer", 1500),
                new Worker("Zahar", 22, "Manager", 2000),
                new Worker("Vadim", 60, "Designer", 1300),
                new Worker("Lera", 70, "Manager", 2500),
            };

            var olders = workers.Where(w => w.Age >= 50).OrderBy(w =>  w.Age);

            foreach (var item in olders)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }

            var workersSpeciality = workers.GroupBy(w => w.Speciality);

            foreach (var worker in workersSpeciality)
            {
                Console.WriteLine(worker.Key);

                foreach (var item in worker)
                {
                    Console.WriteLine($"{item.Name}");
                }
            }

            var middleSalary = workersSpeciality.Select(g => new { Speshiality = g.Key, MiddleSalary = g.Average(w => w.Salary) });

            // var middleSalary = workers.GroupBy(w => w.Speciality).Select(g => new { Speshiality = g.Key, MiddleSalary = g.Average(w => w.Salary)});

            foreach(var item  in middleSalary)
            {
                Console.WriteLine($"{item.Speshiality} - {item.MiddleSalary}");
            }
        }
    }

    class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Speciality { get; set; }
        public int Salary { get; set; }
        public Worker(string name, int age, string speciality, int salary)
        {
            Name = name;
            Age = age;
            Speciality = speciality;
            Salary = salary;
        }
    }
}
