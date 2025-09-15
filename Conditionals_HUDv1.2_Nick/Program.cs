using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_HUDv1._2_Nick
{
    internal class Program
    {
        static int health = 100;

        enum Weapon
        {
            pistol = 0,
            shotGun = 1,
            Spreader = 2,
            Laser = 3,
            Sniper = 4,
            BFG = 5
        }

        static void Main(string[] args)
        {
            if (Weapon == 1)
            {

            }
        }
        static void ChangeWeapon(int weaponPickedUp)
        {
            Console.WriteLine($"Player picked up a {weaponPickedUp}");
        }

        static void TakeDamage(int damage)
        {
            health -= damage;
        }

        static void Heal(int hp)
        {
            health += hp;
        }

        static void ShowHUD()
        {
            Console.WriteLine("{0,0}{1,15}{2,15}", $"Health: {health}, Weapon: {Weapon}, Health Status: ");
            if(int health);
            {
                health = 100;
                Console.Write("Perfect Health");
            }
            if else
            {
                health > 75;
                Console.Write("Healthy");
            }
            if else
            {
                health > 50;
                Console.Write("Hurt");
            }
            if else
            {
                health > 10;
                Console.Write("Badly Hurt");
            }
            else
            {
                health > 1;
                Console.Write("Imminent Danger");
            }
        }

    }
}
