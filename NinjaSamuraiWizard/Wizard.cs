using System;

namespace NinjaSamuraiWizard
{
    public class Wizard:Human
    {
        public Wizard(string name) : base(name, 3, 25, 3, 50) {}
        public void Heal()
        {
            health = health * intelligence;
        }
        public void Fireball(Human opponent)
        {
            Random rnd = new Random();
            int damage = rnd.Next(20, 31);
            opponent.health = opponent.health - damage;
        }
    }
}