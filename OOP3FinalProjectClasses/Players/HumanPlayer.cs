using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3FinalProjectClasses
{
    public class HumanPlayer : Player
    {

        public HumanPlayer(string name)
            : base(name)
        {
        }
        public override Card Attack(Suit trump, List<Rank> possibleRanks)
        {
            Card chosenCard;
            int selectedIndex;
            //Console.WriteLine("{0}'s turn to attack", Name);
            Console.WriteLine("Enter the number of the card you'd like to attack with:");
            myHand.Display();
            selectedIndex = Convert.ToInt32(Console.ReadLine()); //don't really need validation here because things will change when GUI comes anyway
            chosenCard = myHand[selectedIndex];
            return PlayCard(chosenCard);
        }

        public override Card Defend(Card attackCard, Suit trump)
        {
            Card chosenCard;
            int selectedIndex;
            Console.WriteLine("{0}'s is being attacked with a {1}", Name, attackCard.ToString());
            Console.WriteLine("Enter the number of the card you'd like to defend with:");
            myHand.Display();
            selectedIndex = Convert.ToInt32(Console.ReadLine()); //don't really need validation here because things will change when GUI comes anyway
            chosenCard = myHand[selectedIndex];
            return PlayCard(chosenCard);
        }
    }
}
