using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace OOP3FinalProjectClasses
{
    public class Game
    {
        // this will be the class that contains the main game logic

        private Deck gameDeck;

        private Deck discardPile;

        private ArrayList myPlayers;

        public KeyValuePair<int, Player> Attacker { get; private set; } // this holds the attacker's position at the table as the key and the attacking player as the value
        public Player AttackingPlayer
        {
            get
            {
                return Attacker.Value;
            }
        }
        public Player DefendingPlayer { get; private set; }

        public Card LastAttack
        {
            get
            {
                return (Attacks[Attacks.Count-1] as AttackPair).Attack;
            }
        }

        private AttackPair lastAttackPair
        {
            get
            {
                return Attacks[Attacks.Count-1] as AttackPair;
            }
        }

        public List<Rank> AttackRanks; 

        

        public ArrayList Attacks { get; private set; }

        private Card myTrumpCard;
        public Card TrumpCard
        {
            get { return myTrumpCard; }
            set
            { 
                trump = value.Suit;
                myTrumpCard = value;
            }
        }
        public Suit trump;




        public Game(Deck startDeck, int numberOfPlayers)
        {
            throw new NotImplementedException("This is incomplete"); //TODO: Complete this
        }

        public Game(string playerName)
        {
            myPlayers = new ArrayList();
            gameDeck = Deck.StandardDurak();
            myPlayers.Add(new HumanPlayer(playerName));
            myPlayers.Add(new ComputerPlayer("Computer"));
            discardPile = new Deck();
            AttackRanks = new List<Rank>();
            Attacks = new ArrayList();
        }

        public void Start()
        {
            try
            {
                Deal(); // deal the initial hands

                TrumpCard = gameDeck.DrawFrom(); //take the trump card

                SetFirstAttacker();
                while (true)
                {
                    try
                    {
                        do
                        {
                            Attack();
                            Defend();
                        } while (AttackingPlayer.CanAttackAgain(AttackRanks));

                        AttackersLose();
                    }
                    catch (CannotDefendException Cde)
                    {
                        
                        DefenderLoses();
                    }

                }


            }
            catch (OutOfCardsException Ooce)
            {
                //game once deck is gone

                throw new NotImplementedException("The game has no end yet");
            }





        }

        /// <summary>
        /// deals cards to all the players until their hands are full or the deck is empty\
        /// </summary>
        /// <exception cref="OutOfCardsException">When deck is empty</exception>
        private void Deal()
        {
            bool handsFull = false;
            while (!handsFull)
            {
                foreach (Player player in myPlayers)
                {
                    handsFull = true;
                    if (player.CardsInHand < 6)
                    {
                        player.DrawCard(gameDeck);
                        handsFull = false;
                    }
                }
                
            }

        }

        /// <summary>
        /// This is the method that is called when it is time for a player to attack
        /// </summary>
        private void Attack()
        {
            Console.WriteLine("{0} is attacking {1}", AttackingPlayer.Name, DefendingPlayer.Name);
            Attacks.Add(new AttackPair(AttackingPlayer.Attack(trump, AttackRanks)));

        }

        private void Defend()
        {
            if (!DefendingPlayer.CanDefend(LastAttack, trump))
            {
                throw new CannotDefendException("The defending player cannot defend the attack");
            }
            else
            {
                (Attacks[Attacks.Count - 1] as AttackPair).Defend = DefendingPlayer.Defend(LastAttack, trump);
            }
        }

        /// <summary>
        /// This should only be called once, and only after the trump is set and there are players
        /// </summary>
        private void SetFirstAttacker()
        {
            int lowestTrump = 15;
            for (int playerIndex = 0; playerIndex < myPlayers.Count; playerIndex++)
            {
                if ((myPlayers[playerIndex] as Player).LowestTrump(trump) < lowestTrump)
                {
                    lowestTrump = (myPlayers[playerIndex] as Player).LowestTrump(trump);
                    SetNewAttacker(playerIndex);
                }
            }
            SetDefender();
            
        }

        private void SetNewAttacker(int playerNumber)
        {
            Attacker = new KeyValuePair<int, Player>(playerNumber, myPlayers[playerNumber] as Player);
        }

        private void SetDefender()
        {
            if (Attacker.Key + 1 >= myPlayers.Count)
            {
                DefendingPlayer = myPlayers[(Attacker.Key + 1) - myPlayers.Count] as Player;
            }
            else
            {
                DefendingPlayer = myPlayers[Attacker.Key + 1] as Player;
            }
        }

        /// <summary>
        /// this is the logic that happens when a defender loses, its pretty ugly
        /// </summary>
        private void DefenderLoses()
        {
            Deck cardsToDraw = new Deck(); //make a deck to draw all the attacks from. THIS NEEDS TO BE FIXED LATER its dumb


            Console.WriteLine("{} cannot defend, they get the cards and lose their attack.", DefendingPlayer.Name);


            
            foreach(AttackPair pair in Attacks)
            {
                cardsToDraw.Add(pair.Attack);
                cardsToDraw.Add(pair.Defend);
            }
            
            while (cardsToDraw.Count > 0)
            {
                DefendingPlayer.DrawCard(cardsToDraw);
            }


            if ((Attacker.Key + 2) >= myPlayers.Count)
            {
                SetNewAttacker(Attacker.Key + 2 - myPlayers.Count);
            }
            else
            {
                SetNewAttacker(Attacker.Key + 2);
            }

            Attacks = new ArrayList(); // refresh the attacks arraylist
            SetDefender();

            //throw new NotImplementedException("This is not done"); // more to be done here

        }

        private void AttackersLose()
        {

            if ((Attacker.Key + 1) >= myPlayers.Count)
            {
                SetNewAttacker(Attacker.Key + 1 - myPlayers.Count);
                //under construction. logic for making the player after the defender the new attacker
            }
            else
            {
                SetNewAttacker(Attacker.Key + 1);
            }

            Attacks = new ArrayList(); // refresh the attacks arraylist
            SetDefender();
           //throw new NotImplementedException("This is not done"); //more to be done here


        }
    }
}
