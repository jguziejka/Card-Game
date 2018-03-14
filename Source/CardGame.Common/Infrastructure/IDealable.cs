using CardGame.Common.Models;
using System.Collections.Generic;

namespace CardGame.Common.Infrastructure
{
    public interface IDealable
    {
        IEnumerable<Card> GetDealableCards(int count);
    }
}
