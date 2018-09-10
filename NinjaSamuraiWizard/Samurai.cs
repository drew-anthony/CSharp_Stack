namespace NinjaSamuraiWizard
{
    class Samurai:Human
    {
        private static int count = 0;
        public Samurai(string name):base(name)
        {
            health = 200;
            count++;
        }
        public void Death_Blow(Human opponent)
        {
            attack(opponent);
            if(opponent.health < 50)
            {
                opponent.health = 0;
            }
        }
        public void Meditate()
        {
            health = 200;
        }
        public static int How_Many()
        {
            return count;
        }
    }
}