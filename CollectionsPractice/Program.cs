using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] nameArray = {"Tim", "Martin", "Nikki", "Sara"};
            string[] tfArray = new string[10] {"true", "false","true", "false","true", "false","true", "false","true", "false"};
            for(int i=0; i<numArray.Length; i++){
                Console.WriteLine(numArray[i]);
            }
            for(int i=0; i<nameArray.Length; i++){
                Console.WriteLine(nameArray[i]);
            }
            for(int i=0; i<tfArray.Length; i++){
                Console.WriteLine(tfArray[i]);
            }
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Rocky Road");
            flavors.Add("Orange Sherbet");
            flavors.Add("Cotton Candy");
            flavors.Add("Peanut Butter");
            for (var idx=0; idx<flavors.Count; idx++){
                Console.WriteLine(flavors[idx]);
            }            
            Console.WriteLine("We currently know of {0} flavors.", flavors.Count);
            Console.WriteLine(flavors[3]);
            flavors.RemoveAt(3);
            Console.WriteLine("We now have {0} flavors.", flavors.Count);

            Dictionary<string,string> user = new Dictionary<string,string>();
            for (int i=0; i<nameArray.Length; i++){
                user.Add(nameArray[i], flavors[i]);
                Console.WriteLine(nameArray[i], flavors[i]);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
