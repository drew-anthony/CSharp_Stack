using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            Console.WriteLine("There is only one artist in this collection from Mount Vernon, what is their name and age?");
            var findArtist = from artist in Artists
            where artist.Hometown == "Mount Vernon"
            select new { name = artist.ArtistName, age = artist.Age };
            foreach(var artist in findArtist)
            {
                Console.WriteLine($"{artist.name}, {artist.age}");
            }


            Console.WriteLine("Who is the youngest artist in our collection of artists?");
            var youngest = (from artist in Artists
            orderby artist.Age ascending
            select artist.ArtistName).First();
            Console.WriteLine($"{youngest}");


            Console.WriteLine("Display all artists with 'William' somewhere in their real name");
            var realName = Artists.Where(name => name.RealName.Contains("William"));
            foreach(var artist in realName)
            {
                Console.WriteLine($"{artist.RealName}");
            }


            Console.WriteLine("Display the 3 oldest artist from Atlanta");
            var oldest = Artists.Where(artist => artist.Hometown == "Atlanta").OrderByDescending(artist => artist.Age).Take(3);
            foreach(var artist in oldest)
            {
                Console.WriteLine($"{artist.ArtistName}");
            }        


            Console.WriteLine("(Optional) Display the Group Name of all groups that have members that are not from New York City");
            var nonNew = Artists.Where(a => a.Hometown != "New York City").Join(Groups, a => a.GroupId, g => g.Id, (a,g) => new {g.GroupName}).Distinct();
            foreach(var group in nonNew)
            {
                Console.WriteLine($"{group.GroupName}");
            }


            Console.WriteLine("(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'");
            var clan = Groups.Where(g => g.GroupName == "Wu-Tang Clan").Join(Artists,g => g.Id, a => a.GroupId, (g,a) => new {a.ArtistName});
            foreach(var artist in clan)
            {
                Console.WriteLine($"{artist.ArtistName}");
            }
	    Console.WriteLine(Groups.Count);
        }
    }
}
