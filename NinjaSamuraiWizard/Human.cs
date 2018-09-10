using System;

namespace NinjaSamuraiWizard
{
    public class Human
    {
        public string name;
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }

        public void Info()
        {
            Console.WriteLine($"The name is: {name}");
            Console.WriteLine($"The strength is: {strength}");
            Console.WriteLine($"The intelligence is: {intelligence}");
            Console.WriteLine($"The dexterity is: {dexterity}");
            Console.WriteLine($"The health is: {health}");
        }
    }
}