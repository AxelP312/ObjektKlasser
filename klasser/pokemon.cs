using System;

namespace klasser
{
    public class pokemon
    {
        public string name;
        public int health;
        public int damage;
        public int speed;
        public int defense;
        
        public pokemon(string n, int hp, int dmg, int spd, int def)
        {
            name = n;
            damage = dmg;
            health = hp;
            speed = spd;
            defense = def;
        }
    }
}
