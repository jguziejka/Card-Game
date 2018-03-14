using CardGame.Common.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame.Common.Models
{
    public class Deck : IShuffleable, IDealable
    {
        public const int VALID_DECK_COUNT = 52;
        
        public int Count { get { return _cards.Count(); } }

        private List<Card> _cards { get; set; }

        public Deck()
        {
            _cards = new List<Card>();

            var suits = EnumHelper.EnumerateType<Suits>();
            var faceValues = EnumHelper.EnumerateType<FaceValues>();

            foreach (var suit in suits)
            {
                foreach (var faceValue in faceValues)
                {
                    var card = new Card
                    {
                        Suit = suit,
                        FaceValue = faceValue
                    };
                    _cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            // i prefer to shuffle my cards twice 
            for (int i = 0; i < 2; i++)
            {
                RandomSequenceShuffle();
            }
        }
        
        public IEnumerable<Card> GetDealableCards(int count)
        {
            return _cards.Take(count);
        }

        private void RandomSequenceShuffle()
        {
            var cards = _cards.ToArray();
            var random = new Random();
            for (int i = VALID_DECK_COUNT - 1; i > 0; --i)
            {
                var tempCard = cards[i];
                var randomIndex = random.Next(i + 1);
                cards[i] = cards[randomIndex];
                cards[randomIndex] = tempCard;
            }
            _cards = cards.ToList();
        }

    }
}
