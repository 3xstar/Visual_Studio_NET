namespace lesson1
{
    internal class task1
    {
        static void Main1(string[] args)
        {
            Player p1 = new Player("Lera", 1000);
            p1.Heal(1000);
            Console.WriteLine($"Имя: {p1.Name}\nЗдоровье: {p1.GetHealth()}");

            Console.WriteLine('\n');

            Player p2 = new Player("Zakhar", 100);
            p2.Heal(1000);
            Console.WriteLine($"Имя: {p2.Name}\nЗдоровье: {p2.GetHealth()}");
        }
    }

    class Player

    {   //Атрибуты
        public string Name;
        private int Health;
        
        //Конструктор
        public Player(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void Heal(int healPoint)
        {
            Health += healPoint;
        }

        public int GetHealth()
        {
            return Health;
        }
        
    }

}
