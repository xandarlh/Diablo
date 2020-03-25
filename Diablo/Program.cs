using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Program
    {
        static void Main(string[] args)
        {
            //the following is some testcode, to test if the classes and methods works

            //normal axe
            Weapon weapon = new WeaponFactory().Create(0);
            //throwing axe
            Weapon weapon1 = new WeaponFactory().Create(1);
            //twoheadedaxe
            Weapon weapon2 = new WeaponFactory().Create(2);
            //old dagger
            Weapon weapon3 = new WeaponFactory().Create(3);
            //normal mace
            Weapon weapon4 = new WeaponFactory().Create(4);
            //normal sword
            Weapon weapon5 = new WeaponFactory().Create(5);

            Console.WriteLine(weapon.Text());
            Console.WriteLine("");
            Console.WriteLine(weapon1.Text());
            Console.WriteLine("");
            Console.WriteLine(weapon2.Text());
            Console.WriteLine("");
            Console.WriteLine(weapon3.Text());
            Console.WriteLine("");
            Console.WriteLine(weapon4.Text());
            Console.WriteLine("");
            Console.WriteLine(weapon5.Text());

            Console.ReadLine();
        }
    }
}
