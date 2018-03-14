using CardGame.Common.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Common.Models
{
    public class Hand : ISortable
    {
        public List<Card> DealtHand { get; set; }

        public void SortHand()
        {
            throw new NotImplementedException();
        }

        public string ToHandString()
        {
            throw new NotImplementedException();
        }
    }
}
