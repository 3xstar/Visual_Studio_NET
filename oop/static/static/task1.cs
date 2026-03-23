namespace lesson2
{
        internal class task1
        {
            static void Main1(string[] args)
            {
                User u1 = new User("Софья");
                User u2 = new User("Боря");
                User u3 = new User("Женя");
                Console.WriteLine(User.GetTotalUsers());
                Console.WriteLine(User.totalUsers);
            }
        }

        class User
        {
            public string Name { get; private set; }

            public static int totalUsers = 0; // статическое поле

            static User() // статический конструктор, вызывается 1 раз
            {
            Console.WriteLine("Запуск статического конструктора");
                totalUsers = 0;
            }

            public User(string name)
            {
                Console.WriteLine("Запуск конструктора");
                Name = name;
                totalUsers += 1;
            }

            public static int GetTotalUsers() => totalUsers; // статический метод
        }
   }
