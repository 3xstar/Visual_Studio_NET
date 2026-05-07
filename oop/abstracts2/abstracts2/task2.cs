namespace abstracts2
{
    internal class task2
    {
        static void Main(String[] args)
        {
            Dog sharik = new Dog("Шарик");
            Cat barsik = new Cat("Барсик");
            Cow buryonka = new Cow("Бурёнка");

            sharik.MakeSound();
            sharik.Eat();

            barsik.MakeSound();
            barsik.Eat();

            buryonka.MakeSound();
            buryonka.Eat();
        }

        abstract class Animal
        {
            public string Name { get; set; }

            public Animal(string name)
            {
                Name = name;
            }

            public abstract void MakeSound();

            public virtual void Eat()
            {
                Console.WriteLine("Животное ест");
            }

        };

        class Dog : Animal
        {
            public Dog(string name) : base(name) { }

            public override void MakeSound()
            {
                Console.WriteLine("Гав-гав!");
            }

            public override void Eat()
            {
                Console.WriteLine("Собака грызет кость");
            }
        }

        class Cat : Animal
        {
            public Cat(string name) : base(name) { }

            public override void MakeSound()
            {
                Console.WriteLine("Мяу!");
            }
        }

        class Cow : Animal
        {
            public Cow(string name) : base(name) { }
            
            public override void MakeSound()
            {
                Console.WriteLine("Му-у!");
            }
        }
    }
}
