using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace linq
{
    internal class base3
    {
        static void Main3(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Vlad", 29, 1),
                new Student("Sasha", 25, 1),
                new Student("Vova", 27, 1),
                new Student("Nikita", 26, 2),
                new Student("Vadim", 28, 2),
                new Student("Zahar", 23, 2),
            };

            List<Group> groups = new List<Group>()
            {
                new Group(1, "RPO1"),
                new Group(2, "RPO2"),
            };

            var studentsAndGroups = students.Join(
                groups, s => s.GroupId, g => g.Id,
                (s, g) => new { StudentName = s.Name, GroupName = g.Name }
                );

            foreach (var item in studentsAndGroups)
            {
                Console.WriteLine($"Name: {item.StudentName}\nGroup: {item.GroupName}");
            }

            var studentInGroups = groups.GroupJoin(
                students, g => g.Id, s => s.GroupId,
                (g, s) => new { GroupName = g.Name, Students = s.Select(s => s.Name).ToList() }
                );

            foreach (var item in studentInGroups)
            {
                Console.WriteLine($"Группа: {item.GroupName}");
                Console.WriteLine("Список группы: ");

                foreach (var student in item.Students)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }
        public Student(string name, int age, int groupId)
        {
            Name = name;
            Age = age;
            GroupId = groupId;
        }
    }

    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
