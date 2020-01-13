namespace Tasks01.Classes
{
    public class Warrior
    {
        public Sword Sword;

        public Warrior(Sword sword)
        {
            Sword = sword;
        }

        public void Attack()
        {
            Sword.DoDamage();
        }
    }
}
