using System.Drawing;
using System;

namespace OOP3FinalProjectClasses
{
    public class Card : System.ICloneable
    {
        public Rank Rank { get; private set; }
        public Suit Suit { get; private set; }
        public bool FaceUp { get; set; }
        public int Value()
        {
            return (int)Rank;
        }

        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public Card()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Rank.ToString(), Suit.ToString(), Value());
        }

        public object Clone()
        {
            return MemberwiseClone();
        }


        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.Suit == card2.Suit) && (card1.Rank == card2.Rank);
        }

        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }

        public override bool Equals(object card)
        {
            return this == (Card)card;
        }

        public override int GetHashCode()
        {
            return 13 * (int)Suit + (int)Rank;
        }

        public static bool operator >(Card card1, Card card2)
        {
            if (card1.Rank == Rank.Ace)
            {
                if (card2.Rank == Rank.Ace)
                    return false;
                else
                    return true;
            }
            else
            {
                if (card2.Rank == Rank.Ace)
                    return false;
                else
                    return (card1.Rank > card2.Rank);
            }
        }

        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }

        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.Rank == Rank.Ace)
            {
                return true;
            }
            else
            {
                if (card2.Rank == Rank.Ace)
                    return false;
                else
                    return (card1.Rank >= card2.Rank);
            }

        }

        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }

        //public Image GetCardImage()
        //{
        //    string imageName;

        //    if (!FaceUp)
        //    {
        //        imageName = "Back";
        //    }
        //    else
        //    {
        //        imageName = Rank.ToString().ToLower() + "_of_" + Suit.ToString().ToLower();
        //    }

        //    //return // the image
        //}
    }
}

