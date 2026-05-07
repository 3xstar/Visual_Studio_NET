namespace linq
{
    internal class @base
    {
        static void Main1(string[] args)
        {
            List<Human> humans = new List<Human>()
            {
                new Human("Alice", 30),
                new Human("Bob", 25),
                new Human("Charlie", 35),
                new Human("David", 28),
                new Human("Eve", 22),
            };

            var olders = humans.Where(h => h.Age > 25);
            foreach (Human older in humans)
            {
                Console.WriteLine(older.Name);
            }

            Console.WriteLine();

            var names = humans.Select(h => h.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            var data = humans.OrderByDescending(h => h.Age);
            List<Human> sortedHumans = data.ToList();

            foreach (Human human in sortedHumans)
            {
                Console.WriteLine($"{human.Name} {human.Age}");
            }

            var groupByAge = humans.GroupBy(h => h.Age);

            foreach (var group in groupByAge)
            {
                Console.WriteLine($"Age: {group.Key}");
                Console.WriteLine($"Humans with this age:");
                foreach (Human human in group)
                {
                    Console.WriteLine($"{human.Name} {human.Age}");

                }
            }

            float maxAge = humans.Max(h => h.Age);
            float minAge = humans.Min(h => h.Age);
            double averageAge = humans.Average(h => h.Age);
            int sumAge = humans.Sum(h => h.Age);
            int count = humans.Count(h => h.Age < 25);

            Console.WriteLine($"Max Age: {maxAge}," +
                $"Min Age: {minAge}," +
                $"Average Age: {averageAge}," +
                $"Sum Age: {sumAge}," +
                $"Count: {count}");

            Console.WriteLine("ЛОГИЧЕСКИЕ ЗНАЧЕНИЯ");

            bool isZoomers = humans.Any(h => h.Age < 22 && h.Age > 16);
            Console.WriteLine(isZoomers);

            bool allOlderThan18 = humans.All(h => h.Age > 18);

            Console.WriteLine();

            var top3Olders = humans.OrderBy(h => h.Age).Take(3);
            foreach(Human human in top3Olders)
            {
                Console.WriteLine($"{human.Name} {human.Age}");
            }
        }
    }

    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
