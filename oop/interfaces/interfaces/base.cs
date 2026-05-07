namespace interfaces
{
    internal class @base
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    interface IMovable
    {
        const int minSpeed = 0;
        static int maxSpeed = 300;
        public string Name { get; }
        void Move();
    }

    interface ISwimming : IMovable
    {
        int maxDepth { get; }
        string Name {  get; }
        void Swim();
    }

    class Car : IMovable 
    {
        public string Name { get; private set; }
        public void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }

    class AmfibiaCar: IMovable, ISwimming
    {
        public int maxDepth { get; set; }
        public string Name { get; private set; }
        public void Move()
        {
            Console.WriteLine("Амфибия едет");
        }

        public void Swim()
        {
            Console.WriteLine("Амфибия плывет");
        }
    }
}
