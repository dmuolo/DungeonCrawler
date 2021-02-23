using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary1
{
    public class Enemy : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public bool IsSpiked { get; set; }
        public bool IsGround { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }
        }//end MinDamage

        public Enemy(string name, int maxLife, int life, int hitChance, int block, string description, int minDamage, int maxDamage, bool isSpiked, bool isGround) : base(name, maxLife, life, hitChance, block)
        {
            Description = description;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            IsSpiked = isSpiked;
            IsGround = isGround;

        }//end ctor

        public override string ToString()
        {
            return string.Format($"{Name}\n{Description}\nLife: {Life}");
        }//end ToString()

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }//end CalcDamage()

    }
}
