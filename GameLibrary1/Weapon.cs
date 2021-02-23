using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary1
{
    public class Weapon
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public bool IsAir { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }
        }//end MinDamage

        public Weapon(string name, int minDamage, int maxDamage, string description, bool isAir)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;
            IsAir = isAir;
        }//end ctor

        public override string ToString()
        {
            return string.Format("{0}\nDescription:{1}\n{2} to {3} damage\n" +
                "Type:{4}",
                Name,
                Description,
                MinDamage,
                MaxDamage,
                IsAir ? "Air" : "Ground");
        }
    }
}
