using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3FinalProjectClasses
{
    public class Hand : List<Card>
    {
        public Hand() : base() { }

        public void DrawCard(Deck deck)
        {
            this.Add(deck.DrawFrom());
        }
        
        public void Display()
        {
            for (int cardNum = 0; cardNum < this.Count; cardNum++)
            {
                Console.WriteLine("{0}: {1}", cardNum, this[cardNum].ToString());
            }
        }

        public bool HasRank(Rank rank)
        {
            foreach (Card card in this)
            {
                if (card.Rank == rank)
                    return true;
            }
            return false;

        }
    }
}
