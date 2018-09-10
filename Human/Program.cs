using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Drew = new Human("Drew",2,4,6,8);
            Human Daniel = new Human("Daniel",5,6,12,100);

            drew.Attack(daniel,drew.strength);

            System.Console.WriteLine(daniel.health);
            drew.Attack("5",1);

        }
    }
}
