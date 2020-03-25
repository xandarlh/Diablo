using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Mighty_Weapons : Weapon
    {
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
        private RarityType rarityType;
        public override RarityType RarityType
        {
            get { return rarityType; }
            set { rarityType = value; }
        }
        public Mighty_Weapons(string name, double damage, RarityType rarityType)
        {
            this.name = name;
            this.damage = damage;
            this.rarityType = rarityType;
        }
        public override string Text()
        {
            return "Name: " + Name + ", Damage: " + Damage + "\nRarity: " + RarityType;
        }
    }
}
