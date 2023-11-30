using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel
{
    public class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttkMax { get; set; }
        public double DefMax { get; set; }

        Random rnd = new Random();

        public Warrior(string name = "Warrior", double health = 0, double attack = 0, double defence = 0) 
        {
            Name = name;
            Health = health;    
            AttkMax = attack; 
            DefMax = defence;
        }

        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        public virtual double Defend()
        {
            return rnd.Next(1, (int)DefMax);
        }
    }
}
