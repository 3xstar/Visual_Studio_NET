namespace try_catch_finally
{
    internal class Program
    {
        static void AddItem(List<Item> inventory)
        {
            try
            {
                Console.WriteLine("Введите id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите название: ");
                string name = Console.ReadLine();
                inventory.Add(new Item(id, name));
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex}");
            }
            finally
            {
                Console.WriteLine("Программа закончена");
            }
        }

        static void Main(string[] args)
        {
            List<Item> inventory = new List<Item>();
            AddItem(inventory);
        }
    }

    class Item
    {
        public int id { get; set; }
        public string name { get; set; }

        public Item(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}