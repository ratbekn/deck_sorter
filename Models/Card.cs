namespace DeckSorter.Models
{
    public class Card
    {
        public CardSuit Suit { get; }
        public CardRank Rank { get; }

        public Card(CardRank rank, CardSuit suit)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}