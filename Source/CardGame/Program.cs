using CardGame.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Card Game by Joey Guziejka.\nPress any key to play.");
            Console.ReadKey();
            var deck = new Deck();
            Console.WriteLine("\nFirst Lets check the deck");
            var deckCount = deck.Count();
            if (deckCount != Deck.VALID_DECK_COUNT)
            {
                Console.WriteLine($"\nUh oh, I think we lost some cards. Check the couch cushions and under the table. I only found {deckCount} (Press any key to exit)");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"\nCount of Cards in the deck is {deckCount}, now lets shuffle!");
            deck.Shuffle();

        }
    }
}
