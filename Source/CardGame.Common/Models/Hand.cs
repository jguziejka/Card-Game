using CardGame.Common.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame.Common.Models
{
    public class Hand : IDealtable, ISortable
    {
        public List<Card> DealtHand { get; private set; }

        public Hand()
        {
            DealtHand = new List<Card>();
        }

        public void AddCardToHand(Card card)
        {
            DealtHand.Add(card);
        }

        public void SortHand()
        {
            DealtHand = DealtHand.OrderBy(x => (int)x.FaceValue).ToList();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var card in DealtHand)
            {
                sb.Append(card.ToString());
                sb.Append("-");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

    }
}
