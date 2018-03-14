using CardGame.Common.Models;

namespace CardGame.Common.Infrastructure
{
    public interface IDealtable
    {
        void AddCardToHand(Card card);
    }
}
