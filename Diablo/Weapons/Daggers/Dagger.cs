using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Dagger : Weapon
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
        public Dagger(string name, double damage, string blade, RarityType rarityType)
        {
            this.name = name;
            this.damage = damage;
            this.blade = blade;
            this.rarityType = rarityType;
        }
        public override string Text()
        {
            return "Name: " + Name + "\nDamage: " + Damage + "\nBlade: " + Blade + "\nRarity: " + RarityType;
        }
    }
}
