using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_HUDv1._2_Nick
{
    internal class Program
    {
        static int health = 100;
        static Weapon weapon = Weapon.Pistol;

        enum Weapon
        {
            Pistol = 0,
            Shotgun = 1,
            Spreader = 2,
            Laser = 3,
            Sniper = 4,
            BFG = 5
        }

        static void Main(string[] args)
        {
            ChangeWeapon(Weapon.Spreader);
            Console.WriteLine("Hell Yeah");
            ShowHUD();
            Console.ReadKey();
            Console.Clear();

            ChangeWeapon(Weapon.Sniper);
            Console.WriteLine("Hell Yeah");
            ShowHUD();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You were shot in the leg, yeowch!");
            TakeDamage(75);
            ShowHUD();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Mom kissed your boo boos, thank you mom.");
            Heal(50);
            ShowHUD();
            Console.ReadKey();
            Console.Clear();



        }
        static void ChangeWeapon(Weapon weaponPickedUp)
        {
            Console.WriteLine($"Player picked up a {weaponPickedUp}");
            weapon = weaponPickedUp;
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
            Console.Write("{0,0}{1,30}{2,30}", "Health:" + health, "Weapon:" + weapon, "Health Status: ");
            if (health == 100)
            {
                Console.Write("Perfect Health");
            }
            else if (health > 75)
            {
                Console.Write("Healthy");
            }
            else if (health > 50)
            {
                Console.Write("Hurt");
            }
            else if (health > 10)
            {
                Console.Write("Badly Hurt");
            }
            else
            {
                Console.Write("Imminent Danger");
            }
        }
    }
}
