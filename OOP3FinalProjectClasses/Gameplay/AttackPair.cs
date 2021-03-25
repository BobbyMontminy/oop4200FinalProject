using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3FinalProjectClasses
{
    public class AttackPair
    {
        public Card Attack { get; set; }
        public Card Defend { get; set; }

        public AttackPair(Card attackCard)
        {
            Attack = attackCard;
        }

    }
}
