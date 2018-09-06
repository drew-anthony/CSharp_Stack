using System;
using System.Collections.Generic;

namespace Deck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            foreach(var i in deck.cards)
            {
                Console.WriteLine(i.StringVal + " of " + i.Suit + " and int val is " + i.Val);
            }
            deck.shuffle(5);

            foreach (var i in deck.cards)
            {
                Console.WriteLine(i.StringVal + " of " + i.Suit + " and int val is " + i.Val);
            }

            Player cory = new Player("Cory");

            cory.Draw(deck,4);

            foreach (var i in deck.cards)
            {
                Console.WriteLine(i.StringVal + " of " + i.Suit);
            }

            foreach (var i in cory.hand)
            {
                Console.WriteLine(cory.Name + "'s hand includes a " + i.StringVal + " of " + i.Suit);
            }
            cory.Discard(5);
            cory.Discard(2);
            deck.topmost();
            foreach (var i in deck.cards)
            {
                Console.WriteLine(i.StringVal + " of " + i.Suit);
            }

            deck.reset();
            foreach (var i in deck.cards)
            {
                Console.WriteLine(i.StringVal + " of " + i.Suit);
            }
            
        }
    }
}
