using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Short_Sword : Sword
    {
        public Short_Sword(string name, double damage, string blade, RarityType rarityType) : base(name, damage, blade, rarityType)
        {

        }
        public override string Text()
        {
            return "Name: " + Name + "\nDamage: " + Damage + "\nBlade: " + Blade + "\nRarity: " + RarityType;
        }
    }
}
