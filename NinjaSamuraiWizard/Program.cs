using System;

namespace NinjaSamuraiWizard
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Drew = new Wizard("Drew");
            Wizard Heath = new Wizard("Heath");
            Samurai Time = new Samurai("Time");
            Samurai Barry = new Samurai("Barry");
            Samurai Mike = new Samurai("Mike");
            Ninja Gary = new Ninja("Gary");

            Heath.Info();
            Drew.Fireball(Heath);
            Heath.Info();
            Heath.Heal();
            Heath.Info();
            Gary.Info();
            Gary.Steal(Drew);
            Drew.Info();
            Gary.Info();
            Gary.Get_away();
            Gary.Info();
            Time.Info();
            Time.Death_Blow(Drew);
            Drew.Info();
            for(int i = 0; i < 5; i++)
            {
                Heath.attack(Time);
            }
            Time.Info();
            Time.Meditate();
            Time.Info();
            Console.WriteLine($"We have created {Samurai.How_Many()} Samurai's");
        }
    }

}
