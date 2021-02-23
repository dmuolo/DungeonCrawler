using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary1
{
    public class Mario : Character
    {
        public Weapon EquippedWeapon { get; set; }

        public Mario(string name, int maxLife, int life, int hitChance, int block, Weapon equippedWeapon) : base(name, maxLife, life, hitChance, block)
        {
            EquippedWeapon = equippedWeapon;
        }
    }
}
