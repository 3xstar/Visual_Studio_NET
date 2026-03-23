using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1
{
    internal class task2
    {
        static void Main(string[] args)
        {
            Character c1 = new Character("Zakhar", new List<string> {"Water"});
            c1.show_inventory();
            c1.add_item("Eggs");
            c1.add_item("Bread Milk".Split());
            c1.show_inventory();
        }
    }

    class Character
    {
        private List<string> Inventory;
        public string Name;
        public int Capacity;

        public Character(string name)
        {
            Name = name;
            Inventory = new List<string>();
            Capacity = 10;
        }

        public Character(string name, List<string> inventory)
        {
            Name = name;
            Inventory = inventory;
            Capacity = 10;
        }

        public Character(string name, string inventory)
        {
            Name = name;
            Inventory = new List<string>(inventory.Split());
            Capacity = 10;
        }

        public void add_item(string newItem)
        {
            if (Inventory.Count < Capacity)
            {
                Inventory.Add(newItem);
                Console.WriteLine($"Предмет {newItem} добавлен в инвентарь!");
            }
            else
            {
                Console.WriteLine("В инвентаре нет места!");
            }
        }
        public void add_item(string[] newItems)
        {
            if (Inventory.Count < Capacity)
            {
                foreach (string item in newItems)
                {
                    if (Inventory.Count < Capacity)
                    {
                        Inventory.Add(item);
                        Console.WriteLine($"Предмет {item} добавлен в инвентарь!");
                    }
                    else Console.WriteLine("В инвентаре кончилось место!");
                }
            }
        }

        public void show_inventory()
        {
            Console.WriteLine("Вещи в инвентаре:");
            foreach(string item in Inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
