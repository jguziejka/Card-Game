using CardGame.Common.Infrastructure;

namespace CardGame.Common.Models
{
    public class Card
    {
        public Suits Suit { get; set; }
        public FaceValues FaceValue { get; set; }

        public override string ToString()
        {
            return $"{FaceValue.ToShortString()}{Suit.ToShortString()}";
        }
    }
}
