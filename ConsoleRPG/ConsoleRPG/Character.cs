using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Character
    {
        protected int _health;
        protected int _maxHealth;

        public string Name { get; private set; } = "";
        public int Damage { get; private set; }
        public int Armor;


        public int Health
        {
            get { return _health; }
            private set { _health = value; }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
            private set { _maxHealth = value; }
        }

        public Character()
        {

        }
    }
}
