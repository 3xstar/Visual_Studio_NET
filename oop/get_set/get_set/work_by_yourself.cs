using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace get_set
{
    internal class work_by_yourself
    {
        static void Main(string[] args)
        {
            Wizard p1 = new Wizard("Виктор Корнеплод");
            while (true)
            {
                Console.Write("Симулятор мага\nВы - великий маг Виктор Корнеплод\n");
                Console.Write("1. Регенерация маны\n2. Использовать заклинание\n3. Показать количество маны\nВыполните действие (введите от 1 до 3): ");
                string action = Console.ReadLine();
                if (action == "1")
                {
                    p1.Regen();
                }
                if (action == "2")
                {
                    p1.Spell();
                }
                if (action == "3")
                {
                    p1.ShowMana();
                }
            }
        }

        class Wizard
        {
            public string Name { get; }

            private int mana;

            public void ShowMana()
            {
                Console.WriteLine($"\nТекущее количество маны: {mana}\n");
            }

            public void Regen()
            {
                if (mana <= 80)
                {
                    mana += 20;
                    Console.WriteLine("\nВосполнение маны!\n+20 маны за восстановление\n");
                    ShowMana();
                }
                else
                {
                    Console.WriteLine("\nСлишком много маны для восстановленияы!\n");
                    ShowMana();
                }
            }

            public void Spell()
            {
                if (mana >= 20)
                {
                    mana -= 20;
                    Console.WriteLine("\nИспользование заклинания!\n-20 маны за использование\n");
                    ShowMana();
                }
                else
                {
                    Console.WriteLine("\nНедостаточно маны для использования заклинания!\n");
                    ShowMana();
                }
            }

            public Wizard(string name)
            {
                Name = name;
                mana = 0;
            }

        }
    }
}