namespace virtual_methods
{
    internal class task1
    {
        static void Main1(string[] args)
        {
            Device d1 = new Device("RTS5090", "слабая и дешевая видеокарта", 10000);
            SmartPhone s1 = new SmartPhone("IPhone 25", "самый дешевый смартфон apple", 10000, "раскладушка кнопочная");

            d1.ShowInfo();
            s1.ShowInfo();

            d1.Price = 2000;
            Console.WriteLine(d1.Price);

            s1.Price = 1500;
            Console.WriteLine(s1.Price);
        }
    }

    class Device
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        private int price;

        public virtual int Price
        {
            get => price;

            set { if (value > 0) price = value; }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Название {Name}\nОписание {Description}\nЦена {Price}");
        }

        public Device(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
    class SmartPhone : Device
    {
        public string DisplayInfo { get; set; }

        public override int Price 
        {
            get => base.Price;
            set { if (value > 1000) base.Price = value; }
        }

        public SmartPhone(string name, string description, int price,
            string DisplayInfo) : base(name, description, price)
        {
            this.DisplayInfo = DisplayInfo;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Информация о дисплее {DisplayInfo}");
        }
    }
}
