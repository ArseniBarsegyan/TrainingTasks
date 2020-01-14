using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._3Library
{
    class Bow: IWeapons
    {
        private int _Damage;
        public void DoDamage()
        {
            Console.WriteLine($" Bow does {_Damage} in range combat");
        }
    }
}
