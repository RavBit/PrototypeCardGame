using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace CardSystem
{
    public class Program : MonoBehaviour
    {
        //Temp instance for player. Remove this later
        [SerializeField]
        public Player player;
        [SerializeField]
        public List<Card> CardDeck;
        // Use this for initialization
        void Start()
        {
            CardDeck = new List<Card>();
            DeckofCards dc = new DeckofCards();
            dc.SetUpDeck();
            CardDeck = dc.getDeck;
            foreach (Card c in CardDeck)
            {
                Debug.Log("Suit: " + c.CardSuit + "- Value " + c.CardValue);
            }
            player = new Player();
            dc.GiveHand(player.Hand);
            CardDeck = dc.getDeck;
        }
    }
}
