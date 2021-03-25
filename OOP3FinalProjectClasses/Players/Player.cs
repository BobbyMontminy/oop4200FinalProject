using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3FinalProjectClasses
{
    public abstract class Player
    {
        protected Hand myHand;

        public Hand Myhand 
        {
            get
            {
                return myHand;
            }
                
        }

        public int CardsInHand
        {
            get
            {
                return myHand.Count;
            }
        }

        


        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
            myHand = new Hand();
        }

        public Player()
        {
            Name = "Unnamed Player";
            myHand = new Hand();
        }

        /// <summary>
        /// Draws a card from the given deck
        /// </summary>
        /// <param name="deck"> the deck to draw from</param>
        public void DrawCard(Deck deck)
        {
            myHand.DrawCard(deck);
        }

        /// <summary>
        /// Gets the lowest trump card in the players hand
        /// </summary>
        /// <param name="trump"> the trump suit</param>
        /// <returns>the int value of the lowest trump card</returns>
        public int LowestTrump(Suit trump)
        {
            Rank lowest = (Rank)14;

            foreach (Card card in myHand)
            {
                if (card.Suit == trump && card.Rank < lowest)
                {
                    lowest = card.Rank;
                }
            }
            return (int)lowest;
        }

        /// <summary>
        /// this just checks if a player an attack again based on the ranks in hand and the reanks on board
        /// </summary>
        /// <param name="attackableRanks"> the ranks on the board</param>
        /// <returns>true if can attack again false otherwise</returns>
        public bool CanAttackAgain(List<Rank> attackableRanks)
        {
            foreach (Rank rank in attackableRanks)
                if (myHand.HasRank(rank))
                    return true;
            return false;
        }

        /// <summary>
        /// This method determines whether the player can defend from an attack
        /// </summary>
        /// <param name="attackingCard"> the card that was played for the attack</param>
        /// <param name="trumpSuit"> The suit that is currently trump</param>
        /// <returns>true if the player can defend false otherwise</returns>
        public bool CanDefend(Card attackingCard, Suit trumpSuit)
        {
            if (HasTrump(trumpSuit))
                return true; //if there's a trump they can defend

            foreach (Card card in myHand) 
                if (card > attackingCard)
                    return true; //if a card in their hand is higher they can defend

            return false; //else they cant defend
        }

        /// <summary>
        /// This method determines whether the player has a trump card or not
        /// </summary>
        /// <param name="trumpSuit"> the current trump suit</param>
        /// <returns> true if has trump else false</returns>
        public bool HasTrump(Suit trumpSuit)
        {
            foreach (Card card in myHand)
                if (card.Suit == trumpSuit)
                    return true;
            return false;
        }

        protected Card PlayCard(Card cardToPlay)
        {
            myHand.Remove(cardToPlay);
            return cardToPlay;
        }


        /// <summary>
        /// This is the method that will contain the logic as to how to attack and will be defined in
        /// child classes ComputerPlayer and HumanPlayer.
        /// </summary>
        /// <param name="trump">the trump suit</param>
        /// <param name="possibleRanks"> the list of ranks that arer valid to play</param>
        /// <returns></returns>
        public abstract Card Attack(Suit trump, List<Rank> possibleRanks);

        /// <summary>
        /// this is the method that will contain logic on how the player defends and will be defined 
        /// in the child classes
        /// </summary>
        /// <param name="attackCard">the attacking card</param>
        /// <param name="trump">the trump suit for the game</param>
        /// <returns></returns>
        public abstract Card Defend(Card attackCard, Suit trump);


    }
}
