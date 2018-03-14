using CardGame.Common.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Common.Models
{
    public class Deck : IShuffleable
    {
        public const int VALID_DECK_COUNT = 52;

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
            // first we split the deck
            var leftHand = _cards.Take(26);
            var rightHand = _cards.Skip(26).Take(26);
            if (leftHand.Count() != 26 || rightHand.Count() != 26)
            {
                return; // nope
            }
        }

        public int Count()
        {
            return _cards.Count();
        }


        private void RiffleShuffle()
        {

        }

    }
}
