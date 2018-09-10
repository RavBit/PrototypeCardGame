using System;
using System.Collections.Generic;
using System.Linq;

namespace CardSystem
{
    class DeckofCards : Card
    {
        const int NUM_OF_CARDS = 20; // Number of total cards in the game
        private readonly List<Card> deck; // array of all playing cards in the deck

        public DeckofCards()
        {
            deck = new List<Card>(); // Deck with the total number of cards in the game
        }

        public List<Card> getDeck { get { return deck; } } // Get the current deck

        //Create deck of 20 cards: 5 values with 4 suits
        public void SetUpDeck()
        {
            int i = 0;
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach(VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck.Add(new Card { CardSuit = s, CardValue = v });
                    i++;
                }
            }
            ShuffleCards();
        }
        
        //ShuffleDeck
        public void ShuffleCards()
        {
            Random r = new Random();
            Card tempcard;

            //Run the Shuffle 1000 times
            for (int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes ++)
            {
                for(int i = 0; i < NUM_OF_CARDS; i++)
                {
                    //Swap the cards
                    int secondCardIndex = r.Next(5);
                    tempcard = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = tempcard;
                }
            }
        }
        public List<Card> GiveHand(List<Card> Hand)
        {
            for (int i = 0; i < 3; i++)
            {
                Random r = new Random();
                int randomint = r.Next(deck.Count);
                Hand.Add(deck[randomint]);
                deck.Remove(deck[randomint]);
            }

            return Hand;
        }
    }
}
