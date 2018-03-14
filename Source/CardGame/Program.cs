using CardGame.Common.Models;
using System;

namespace CardGame
{
    class Program
    {
        const int NUMBER_OF_PLAYERS = 5;
        const int NUMBER_OF_CARDS_PER_HAND = 5;

        static void Main(string[] args)
        {
            Console.WriteLine("Card Game by Joseph Guziejka. Press any key to play.");
            Console.ReadKey();

            var deck = new Deck();
            Console.WriteLine("\nFirst Lets check the deck\n");

            var deckCount = deck.Count;
            if (deckCount != Deck.VALID_DECK_COUNT)
            {
                Console.WriteLine($"Uh oh, I think we lost some cards. Check the couch cushions and under the table. I only found {deckCount} (Press any key to exit)\n");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"Count of Cards in the deck is {deckCount}, now lets shuffle!\n");

            deck.Shuffle();
            Console.WriteLine("Shuffling complete. Time to deal!\n");

            var players = new Players(NUMBER_OF_PLAYERS);
            var dealableCards = deck.GetDealableCards(NUMBER_OF_PLAYERS * NUMBER_OF_CARDS_PER_HAND);
            players.DealPlayerHands(dealableCards, NUMBER_OF_PLAYERS);
            players.SortPlayerHands();
            Console.WriteLine("The Cards are dealt, now show your hands!\n");

            var gamePath = players.CreateGameOutput();
            Console.WriteLine($"Game Data Location: {gamePath}\n");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
