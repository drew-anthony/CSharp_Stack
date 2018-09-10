namespace NinjaSamuraiWizard
{
    class Ninja:Human
    {
        public Ninja(string name):base(name)
        {
            dexterity = 175;
        }
        public void Steal(Human opponent)
        {
            attack(opponent);
            health += 10;
        }
        public void Get_away()
        {
            health -= 15;
        }
    }
}