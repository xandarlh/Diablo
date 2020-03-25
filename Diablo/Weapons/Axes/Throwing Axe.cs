using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Throwing_Axe : Axe
    {
        private double throwdistance;
        public double Throwdistance
        {
            get { return throwdistance; }
            set { throwdistance = value; }
        }

        public Throwing_Axe(string name, double damage, string shaft, double throwdistance, RarityType rarityType) : base(name, damage, shaft, rarityType)
        {
            this.throwdistance = throwdistance;
        }
        public override string Text()
        {
            return "Name: " + Name + "\nDamage: " + Damage + "\nShaft material: " + Shaft + "\nThrowdistance: " + Throwdistance + "\nRarity: " + RarityType;
        }
    }
}
