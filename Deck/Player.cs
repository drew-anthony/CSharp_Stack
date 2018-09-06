using System;
using System.Collections.Generic;

namespace Deck
{
    public class Player
    {
        public string Name;
        public List<Card> hand = new List<Card>();
        public Player(string name)
        {
            Name = name;
        }

        public List<Card> Draw(Deck deck, int times)
        {
            while(times>0)
            {
                Card draw = deck.cards[0];
                hand.Add(draw);
                deck.cards.Remove(draw);
                Console.WriteLine("You drew {0} of {1}", draw.StringVal, draw.Suit);
                times--;
            }
            return hand;
        }
        public Card Discard(int num){
            if(num > hand.Count)
            {
                Console.WriteLine("that is too many cards buddy");
                return null;
            }
            else{
            Card drop = hand[num];
            hand.Remove(drop);
            Console.WriteLine("You discarded {0} of {1}", drop.StringVal, drop.Suit);
            return drop;
            }
        }
    }
}
