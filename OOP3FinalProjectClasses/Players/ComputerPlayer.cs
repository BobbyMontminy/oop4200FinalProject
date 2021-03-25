using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3FinalProjectClasses
{
    public class ComputerPlayer : Player
    {
        public int Difficulty { get; private set; }

        private static Random myRandom = new Random();

        public ComputerPlayer(String name)
            : base(name)
        {
            Difficulty = 1;
        }

        public ComputerPlayer(String name, int difficulty)
            : base(name)
        {
            Difficulty = difficulty;
        }

        public override Card Attack(Suit trump, List<Rank> possibleRanks)
        {
            
            if (possibleRanks.Count == 0)
            {
                // First Attack
                int randomCard = myRandom.Next(myHand.Count); //chose a rand number between 0 and the number of cards in the hand
                return PlayCard(myHand[randomCard]);
            }
            else
            {
                // Other attacks
                List<Card> playableCards = new List<Card>(); // this will be a list of the playable cards
                foreach (Card card in myHand)
                {
                    if (possibleRanks.Contains(card.Rank))
                    {
                        playableCards.Add(card); // add all the playable cards to the list
                    }
                }

                int randomCard = myRandom.Next(playableCards.Count); // chose a rand number between 0 and the number of cards that are playable


                //play card removes the card from the hand and returns the card
                return PlayCard(playableCards[randomCard]); 

                //foreach (Card card in playableCards)
                //{
                //    Console.WriteLine(card.ToString()); // this displays each playable card for debugging
                //}

                //var random = new Random();
                //int randomCard = random.Next(playableCards.Count);

            }



            throw new NotImplementedException("This is not done");
        }

        public override Card Defend(Card attackCard, Suit trump)
        {
            List<Card> playableCards = new List<Card>(); // this will be a list of the playable cards
            foreach (Card card in myHand)
            {
                if (card > attackCard || card.Suit == trump)
                {
                    playableCards.Add(card);
                }
            }

            int randomCard = myRandom.Next(playableCards.Count); // chose a rand number between 0 and the number of cards that are playable

            return PlayCard(playableCards[randomCard]);
            //foreach (Card card in playables)
            //{
            //    Console.WriteLine(card.ToString()); // this displays each playable card for debugging
            //}



            //throw new NotImplementedException("This is not done");
        }
    }
}
