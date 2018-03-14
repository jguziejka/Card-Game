using CardGame.Common.Models;
using System.Collections.Generic;

namespace CardGame.Common.Infrastructure
{
    public interface IPlayable
    {
        void DealPlayerHands(IEnumerable<Card> cards, int numberOfPlayers);
        void SortPlayerHands();
        string CreateGameOutput();
    }
}
