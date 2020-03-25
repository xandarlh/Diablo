using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Twoheaded_Axe : Axe
    {        
        public Twoheaded_Axe(string name, double damage, string shaft, RarityType rarityType) : base(name, damage, shaft, rarityType)
        {
            
        }
        public override string Text()
        {
            return "Name: " + Name + "\nDamage: " + Damage + "\nShaft material: " + Shaft + "\nRarity: " + RarityType;
        }
    }
}
