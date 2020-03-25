using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    //the class is made abstract, because there is no reason to instansiate the class
    public abstract class Weapon
    {
        public abstract RarityType RarityType { get; set; }

        public abstract string Name { get; set; }

        public abstract double Damage { get; set; }

        public abstract string Text();
    }
}
