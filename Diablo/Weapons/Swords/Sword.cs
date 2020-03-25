using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Sword : Weapon
    {
        public List<string> SwordProperties = new List<string>();

        private string name;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double damage;
        public override double Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        private string blade;
        public string Blade
        {
            get { return blade; }
            set { blade = value; }
        }
        private RarityType rarityType;
        public override RarityType RarityType
        {
            get { return rarityType; }
            set { rarityType = value; }
        }
        public Sword(string name, double damage, string blade, RarityType rarityType)
        {
            this.name = name;
            this.damage = damage;
            this.blade = blade;
            this.rarityType = rarityType;

            //this add different "magical properties" for the sword, which can then be selected
            SwordProperties.Add("+20 Cold Damage, ");
            SwordProperties.Add("+7% Increased Attack Speed, ");
            SwordProperties.Add("Reduced Cooldown of all Skills by 9%, ");
            SwordProperties.Add("+3 Life per Kill");
            SwordProperties.Add("12% Chance to Stun on hit");
        }
        public override string Text()
        {
            StringBuilder st = new StringBuilder();

            //this selects magic properties to add to the sword, and it selects specifik amount of props based on the rarity of the weapon
            if (RarityType == RarityType.Common)
            {
                for (int i = 0; i < 2; i++)
                {
                    st.Append(SwordProperties.ElementAt(i));
                }
            }
            if (RarityType == RarityType.Magic)
            {
                for (int i = 0; i < 3; i++)
                {
                    st.Append(SwordProperties.ElementAt(i));
                }
            }
            return "Name: " + Name + "\nDamage: " + Damage + "\nBlade: " + Blade + "\nRarity: " + RarityType + "\nMagic: " + st.ToString();
        }
    }
}
