namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Borya", 22);
            h1.Age = 50;
            //h1.Name = "Borya"
            h1.ShowInfo();
            
            Builder b1 = new Builder("Grisha", 22, 100);
            b1.Age = 40;
            b1.SetName("Grisha");
            b1.Exp = 100;

            b1.ShowInfo();
            Console.WriteLine($"{b1.Age}, {b1.Name}, {b1.Exp}");
        }
    }

    class Human
    {
        public string Name {get; protected set;}
        public  int Age {get; set;}

        public Human(string name, int age )
        {
            Name = name;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}, {Age}");
        }
    }

    class Builder : Human
    {
        public int Exp { get; set; }

        public Builder(string name, int age, int exp) : base(name, age)
        {
            Exp = exp;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        // НЕПРАВИЛЬНО ДУБЛИРОВАТЬ МЕТОДЫ (ShowInfo для примера)
        public void ShowInfo()
        {
            Console.WriteLine($"{Name}, {Age}, {Exp}");
        }
    }
}