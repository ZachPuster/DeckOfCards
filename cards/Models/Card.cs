namespace cards.Models
{
    public class Card
    {
        public Suit suit { get; }
        public Rank rank { get; }

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
    }
}