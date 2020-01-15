using System;

namespace Task1._3Library
{
    public class Bow: IWeapon
    {
        private int _damage;

        public void DoDamage()
        {
            Console.WriteLine($" Bow does {_damage} in range combat");
        }
    }
}
