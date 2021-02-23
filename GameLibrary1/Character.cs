using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary1
{
    public abstract class Character
    {
        private int _life;

        public int MaxLife { get; set; }
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                _life = value <= MaxLife ? value : MaxLife;
            }
        }

        public Character(string name, int maxLife, int life, int hitChance, int block)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            HitChance = hitChance;
            Block = block;
        }//protected says that class is available. like internal. available within project it's created or to children of its class
        public Character()
        {
        }

        public virtual int CalcBlock()//instance method already knows everything about the player and the monster
        {
            return Block;//don't need to do this by itself, but with the virtual keyword, it allows us to change this functionality in the child classes
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()//virtual allows us to override but doesn't require us to
        {
            return 0;
        }//we can't set base functionality here. Player's damage will rely on EquippedWeapon
    }
}
