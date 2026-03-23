using System;
using System.Collections.Generic;
using System.Text;

namespace get_set
{
    internal class task1
    {
        void Main2(string[] args)
        {
            Player p1 = new Player("Иван");
            p1.Exp = 10000;
            p1.Exp = 10000;
            p1.Exp = 10000;
            Console.WriteLine($"Имя {p1.Name} уровень {p1.Level} опыт {p1.Exp}");
        }
    }

    class Player
    {
        public string Name { get; }
        public byte Level { get; private set; }
        private int _exp;

        public int Exp
        {
            get { return _exp; }
            set
            {
                if (value > 0)
                {
                    _exp += value;
                    while (_exp > Level * Level * 100)
                    {
                        Level += 1;
                    }
                }
            }
        }

        public Player(string name)
        {
            Name = name;
            Level = 1;
            _exp = 0;
        }

    }
}