using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel
{
    public class MagicWarrior : Warrior
    {
        int teleportChance = 0;
        CanTeleport teleportType = new CanTeleport();

        public MagicWarrior(string name = "warrior", double health = 0, double attack = 0, double defence = 0, int teleportChance = 0) : base(name, health, attack, defence)    
        {
            this.teleportChance = teleportChance;
        }

        public override double Defend()
        {
            Random rnd = new Random();
            int rndDodge = rnd.Next(1, 100);

            if (rndDodge < this.teleportChance)
            {
                Console.WriteLine($"{Name} {teleportType.Teleport()}");
                return 10000;
            }
            else
            {
                return base.Defend();
            }
        }
    }
}
