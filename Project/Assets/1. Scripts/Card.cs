namespace CardSystem
{
    [System.Serializable]
    public class Card
    {
        //Kind of suits used in this game
        public enum SUIT
        {
            HEARTS = 0,
            SPADES,
            DIAMONDS,
            CLUBS
        }

        //Kind of values used in this game
        public enum VALUE
        {
            TEN = 0, JACK, QUEEN, KING, ACE
        }

        //Properties when the cards recieve data     
        public SUIT CardSuit { get; set; }
        public VALUE CardValue { get; set; }
    }
}
