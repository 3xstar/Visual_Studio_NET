namespace lesson2
{
    internal class Program
    {
        static void changeNumber(ref int number, int newNumber)
        {
            number = newNumber;
        }

        static void Main(string[] args)
        {
            ForeignPassport fp = new ForeignPassport("Russia", "Borya");
            fp.AddVisa("USA", 30);
            int num = 10;
            changeNumber(ref num, 223233);

            int action;

            while (true)
            {
                Console.Write("=====VISA MANAGER БОРИ======\n" +
                    "1. Вывести информацию о человеке\n" +
                    "2. Добавление визы\n" +
                    "3. Удаление визы у человека\n" +
                    "4. Изменение номера паспорта\n" +
                    "Введите действие: ");

                action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    Console.WriteLine("Имя: " + fp.Name);
                    Console.WriteLine("Страна проживания: " + fp.Country);
                    Console.WriteLine("Номер паспорта: " + fp.Number);
                    if (fp.visas.Count > 0)
                    {
                        Console.WriteLine("Статус визы: есть");
                        int index = 0;
                        foreach (object visa in fp.visas)
                        {
                            Console.WriteLine("Виза номер: " + index);
                            Console.WriteLine("Страна для визы: " + fp.visas[index].Country);
                            Console.WriteLine("Количество дней для визы: " + fp.visas[index].Days);
                            index += 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Статус визы: нету");
                    }
                }
                else if (action == 2)
                {
                    Console.Write("Введите страну для визы: ");
                    string c = Console.ReadLine();

                    Console.Write("Введите количество дней для визы: ");
                    int d = Convert.ToInt32(Console.ReadLine());

                    fp.AddVisa(c, d);
                    Console.WriteLine("Виза успешно добавлена!");
                }
                else if (action == 3)
                {
                    if (fp.visas.Count > 0)
                    {
                        Console.WriteLine("Статус визы: есть");
                        int index = 0;
                        foreach (object visa in fp.visas)
                        {
                            Console.WriteLine("Виза номер: " + index);
                            Console.WriteLine("Страна для визы: " + fp.visas[index]);
                            Console.WriteLine("Количество дней для визы: " + fp.visas[index].Days);
                            index += 1;
                        }
                        Console.Write("Введите номер визы для удаления: ");
                        int del_index = Convert.ToInt32(Console.ReadLine());
                        fp.visas.RemoveAt(del_index);
                        Console.WriteLine("Виза успешно удалена!");
                    }
                    else
                    {
                        Console.WriteLine("Статус визы: нету");
                    }
                }
                else if (action == 4)
                {
                    Console.WriteLine("Текущий номер паспорта: " + fp.Number);
                    Console.WriteLine("Введите новый номер паспорта: ");
                    int new_numb = Convert.ToInt32(Console.ReadLine());
                    changeNumber(ref fp.Number, new_numb);
                    Console.WriteLine("Паспорт успешно изменен!");
                }
            }
        }

        class Passport
        {
            public string Country { get; set; }
            public string Name { get; set; }

            public int Number;

            public Passport(string country, string name)
            {
                Country = country;
                Name = name;
                Random random = new Random();
                Number = random.Next(100000, 999999);
            }
        }

        class ForeignPassport : Passport
        {
            public List<Visa> visas = new List<Visa>();

            public ForeignPassport(string country, string name) : base(country, name)
            {

            }

            public void AddVisa(string country, int days)
            {
                visas.Add(new Visa(country, days));
            }
        }

        class Visa
        {
            public string Country { get; set; }

            public int Days { get; set; }

            public Visa(string country, int days)
            {
                Country = country;
                Days = days;
            }
        }
    }
}
