
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class WeaponFactory
    {       
        //this instansiet new weapons
        public Weapon Create(int type)
        {
            if (type == 0)
            {
                return new Axe("Hand Axe", 3.2, "Wood", RarityType.Common);
            }
            if (type == 1)
            {
                return new Throwing_Axe("Broad Axe", 7.1, "Wood and gold", 6.4, RarityType.Legendary);
            }
            if (type == 2)
            {
                return new Twoheaded_Axe("Twoheaded axe", 69, "Wood", RarityType.Magic);
            }
            if (type == 3)
            {
                return new Dagger("Olddagger", 1, "Metal", RarityType.Rare);
            }
            if (type == 4)
            {
                return new Mace("Mace", 9, RarityType.Common);
            }
            if(type == 5)
            {
                return new Sword("ddd", 3, "Metal", RarityType.Magic);
            }
            return null;
        }
    }
}
