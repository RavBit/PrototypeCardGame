using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CardSystem
{
    public class Program : MonoBehaviour
    {
        [SerializeField]
        public List<Card> CardDeck;
        // Use this for initialization
        void Start()
        {
            CardDeck = new List<Card>();
            DeckofCards dc = new DeckofCards();
            dc.SetUpDeck();
            Card[] cd = dc.getDeck;
            foreach (Card c in cd)
            {
                Debug.Log("Suit: " + c.CardSuit + "- Value " + c.CardValue);
                CardDeck.Add(c);
            }
        }
    }
}
