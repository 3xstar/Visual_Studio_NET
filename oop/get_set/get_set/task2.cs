using System;
using System.Collections.Generic;
using System.Text;

namespace get_set
{
    internal class task2
    {
        static void Main3(string[] args)
        {
            Item i1 = new Item("Молоко", "d1");
            Item i2 = new Item("Вода", "d2");
            Item i3 = new Item("Хлебушек", "d3");

            Inventory inventory = new Inventory();
            inventory.MaxSlots = 7;
            inventory.AddItem(i1);
            inventory.AddItem(i2);
            inventory.AddItem(i3);
            inventory.ShowItems();
        }
    }
}

class Inventory
{
    public List<Item> Items { get; private set; }

    private int _maxSlots = 1;

    public int MaxSlots
    {
        get { return _maxSlots; }
        set { if(value > 0) _maxSlots = value;  }
    }

    public Inventory()
    {
        Items = new List<Item>();
    }

    public void AddItem(Item newItem)
    {
        if (Items.Count < MaxSlots) Items.Add(newItem);
    }

    public void ShowItems()
    {
        foreach(Item item in Items)
        {
            Console.WriteLine($"{item.Name} - {item.Description}");
        }
    }
}

class Item
{
    public string Name {get;}

    public string Description { get;}

    public Item(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
