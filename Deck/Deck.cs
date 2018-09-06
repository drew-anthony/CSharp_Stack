using System;
using System.Collections.Generic;

namespace Deck
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public List<string> cardName = new List<string> {"Ace","2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        public List<string> cardSuit = new List<string> {"Diamonds","Hearts","Clubs","Spades"};

    public Deck() {
        for (int i = 0; i< cardSuit.Count; i++)
        {
            for (int j = 0; j < cardName.Count; j++)
            {
                var suit = cardSuit[i];
                var StringVal = cardName[j];
                var val = j+1;
                Card delt = new Card(StringVal, suit, val);
                cards.Add(delt);
            }
        }
    }
    public Card topmost(){
        Card topcard = cards[0];
        cards.RemoveAt(0);
        Console.WriteLine("The top card was {0} of {1}" , topcard.StringVal, topcard.Suit);
        return topcard;
    }
    public void reset(){
        cards.Clear();
        Console.WriteLine("Starting a New Game!");
            for (int i = 0; i < cardSuit.Count; i++)
            {
                for (int j = 0; j < cardName.Count; j++)
                {
                    var suit = cardSuit[i];
                    var StringVal = cardName[j];
                    var val = j + 1;
                    Card delt = new Card(StringVal, suit, val);
                    cards.Add(delt);
                }
            }
    }
    public void shuffle(int num){
        for(int i = 0; i<num; i++)
        {
            for(int p = 0; p<cards.Count; p++)
            {
                Random rand = new Random();
                var id = rand.Next(cards.Count);
                var temp = cards[id];
                cards[id] = cards[p];
                cards[p] = temp;
            }
        }
    }
    }
}
