using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Old_Dagger : Dagger
    {
        private bool isRusty;
        public bool IsRusty
        {
            get { return isRusty; }
            set { isRusty = value; }
        }

        public Old_Dagger(string name, double damage, string blade, bool isRusty, RarityType rarityType) : base(name, damage, blade, rarityType)
        {
            this.isRusty = isRusty;
        }
        public override string Text()
        {
            return "Name: " + Name + "\nDamage: " + Damage + "\nBlade: " + Blade + "\nRusty: " + IsRusty + "\nRarity: " + RarityType;
        }
    }
}
