using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3FinalProjectClasses
{
    public class Deck : List<Card>
    {
        private static Random myRandom = new Random();

        public Card DrawFrom()
        {
            if (this.Count > 0)
            {
                Card retCard = this[0];
                this.Remove(retCard);
                return retCard;
            }
            else
            {
                throw new OutOfCardsException("The deck is out of cards");
            }
        }
        public static Deck StandardDeck()
        {
            Deck newDeck = new Deck();
            for (int rank = 2; rank < 15; rank++) //iterate through ranks
            {
                for (int suit = 1; suit < 4; suit++) //iterate through suits
                {
                    newDeck.Add(new Card((Rank)rank, (Suit)suit)); //add a card to the deck for each rank, suit combo
                }
            }
            newDeck.Shuffle();
            return newDeck;
        }
        // this method returns the standard 32-card Durak Deck
        public static Deck StandardDurak()
        {
            Deck newDeck = new Deck();
            for (int rank = 2; rank < 15; rank++) //iterate through ranks
            {
                if ( rank > 5 ) // because 2 - 5 are removed
                {
                    for (int suit = 1; suit < 4; suit++) //iterate through suits
                    {
                        newDeck.Add(new Card((Rank)rank, (Suit)suit)); //add a card to the deck for each rank, suit combo
                    }
                }
            }
            newDeck.Shuffle();
            return newDeck;
        }

        public Deck() : base() { }

        //This is a method that shuffles the deck it uses the Fisher-Yates shuffle
        public void Shuffle()
        {
            int counter = this.Count;
            while (counter > 1)
            {
                counter--;
                int k = myRandom.Next(counter + 1);
                Card holder = this[k];
                this[k] = this[counter];
                this[counter] = holder;
            }
        }


    }
}
