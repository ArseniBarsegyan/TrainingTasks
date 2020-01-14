using System;

namespace Task1._3Library
{
    public class Sword: IWeapons
    {
        private int _Damage;
        public void DoDamage()
        {
            Console.WriteLine($"Sword does {_Damage} in melee combat");
        }
    }
}
