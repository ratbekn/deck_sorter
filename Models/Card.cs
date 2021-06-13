namespace DeckSorter.Models
{
    public class Card
    {
        private int rank;
        private CardSuit suit;

        public Card(int rank, CardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }
    }
}