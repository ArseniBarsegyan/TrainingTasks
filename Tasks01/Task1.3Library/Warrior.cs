namespace Task1._3Library
{
    public class Warrior
    {
        private IWeapon _weapon;

        public Warrior(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            _weapon.DoDamage();
        }
    }
}
