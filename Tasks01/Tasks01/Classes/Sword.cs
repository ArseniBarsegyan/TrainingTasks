using System;

namespace Tasks01.Classes
{
    public class Sword
    {
        public int Damage;

        public void DoDamage()
        {
            Console.WriteLine($"Sword does {Damage} in melee combat");
        }
    }
}
