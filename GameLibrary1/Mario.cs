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

        public override string ToString()
        {
            return string.Format("Life: {0} of {1}\n" +
                "Hit Chance: {2}%\nBlock: {3}%\n",
                Life,
                MaxLife,
                CalcHitChance(),//to see modified value
                Block);
        }

        public override int CalcDamage()
        {
            return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }

        public override int CalcHitChance()
        {
            return HitChance;
        }

    }
}
