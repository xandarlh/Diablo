using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Axe : Weapon
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
        private string shaft;
        public string Shaft
        {
            get { return shaft; }
            set { shaft = value; }
        }
        private RarityType rarityType   ;
        public override RarityType RarityType
        {
            get { return rarityType; }
            set { rarityType = value; }
        }
        public Axe(string name, double damage, string shaft, RarityType rarityType)
        {
            this.name = name;
            this.damage = damage;
            this.shaft = shaft;
            this.rarityType = rarityType;
        }
        //this is a method to return the properties of "axe"
        public override string Text()
        {
            return "Name: " + Name + "\nDamage: " + Damage + "\nShaft material: " + Shaft + "\nRarity: " + RarityType;
        }
    }
}
