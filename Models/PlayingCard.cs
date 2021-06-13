namespace DeckSorter.Models
{
    public class PlayingCard : ICard
    {
        private int rank;
        private PlayingCardSuit suit;
        public int Number { get; }

        public PlayingCard(int rank, PlayingCardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
            Number = this.rank;
        }
    }
}