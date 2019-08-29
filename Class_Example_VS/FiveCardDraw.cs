using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example_VS
{
    class FiveCardDraw
    {
        /// <summary>
        /// Gets or sets the Cards in the Player's hand. 
        /// </summary>
        public List<Card> PlayerHand { get; set; }

        /// <summary>
        /// Gets or sets the Cards in the Deck. 
        /// </summary>
        public DeckOfCards deckOfCards { get; set; }

        /// <summary>
        /// Creates a new game of Five Card Draw with a deckof 52 cards. 
        /// </summary>
        public FiveCardDraw()
        {
            deckOfCards = new DeckOfCards();
            deckOfCards.Shuffle();
            PlayerHand = new List<Card>();
        }

        private bool[] Discard;

        /// <summary>
        /// Play a hand of 5 card draw. 
        /// </summary>
        public void PlayRound()
        {
            Discard = new bool[5] { false, false, false, false, false };
            string userChoice;
            int discardMe = 0;

            //deal five cards to player
            for (int n = 0; n < 5; n++)
            {
                PlayerHand.Add(deckOfCards.Deal());
            }

            //discard loop
            do
            {
                ShowPlayerHand();

                Console.WriteLine("Type the number of the card in your hand and hit Enter to toggle between Keep/Discard.");
                Console.Write("Type 'D' to finalize dicard or 'exit' to quit game? ");
                userChoice = Console.ReadLine();

                if (userChoice.ToLower() == "exit") { System.Environment.Exit(0);}

                //input validation loop
                while (userChoice != "D" && !int.TryParse(userChoice, out discardMe))
                {
                    Console.WriteLine("Invalid choice. Try Again: ");
                    userChoice = Console.ReadLine();
                }

                //toggle element using ternary operator.
                if (userChoice != "D" && discardMe > 0 && discardMe < 6)
                {
                    Discard[discardMe - 1] = Discard[discardMe - 1] == true ? false : true;
                }

            } while (userChoice != "D");

            FinalizeDiscard();
            ShowPlayerHand();

        }//play Round

        private void FinalizeDiscard()
        {
            for (int n = 0; n < PlayerHand.Count; n++)
            {
                //if card marked to be discarded, replace with card from deck.
                if (Discard[n])
                {
                    deckOfCards.Deck.Add(PlayerHand[n]);
                    PlayerHand[n] = deckOfCards.Deal();
                }
            }

            //reset  Discard bool array.
            Discard = new bool[5] { false, false, false, false, false };
        }

        /// <summary>
        /// Display each card in the Player's hand. 
        /// </summary>
        public void ShowPlayerHand()
        {
            for (int n = 0; n < PlayerHand.Count; n++)
            {
                if (!Discard[n])
                    Console.WriteLine("Card #" + (n + 1) + ": " + PlayerHand[n]);
                else
                    Console.WriteLine("Card #" + (n + 1) + ": " + PlayerHand[n] + "<---Discard");
            }
        }
    }
}

