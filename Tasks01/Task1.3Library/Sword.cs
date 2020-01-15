using System;

namespace Task1._3Library
{
    public class Sword: IWeapon
    {
        private int _damage;

        public void DoDamage()
        {
            Console.WriteLine($"Sword does {_damage} in melee combat");
        }
    }
}
