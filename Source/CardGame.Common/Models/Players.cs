using CardGame.Common.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;

namespace CardGame.Common.Models
{
    public class Players : IPlayable
    {
        public Hand[] Hands { get; private set; }

        public Players(int playerCount)
        {
            Hands = new Hand[playerCount];
            for (int i = 0; i < playerCount; i++)
            {
                Hands[i] = new Hand();
            }
        }

        public void DealPlayerHands(IEnumerable<Card> cards, int numberOfPlayers)
        {
            int playerTurn = 0;
            foreach (var card in cards)
            {
                Hands[playerTurn].AddCardToHand(card);
                if (playerTurn == numberOfPlayers - 1)
                {
                    playerTurn = 0;
                }
                else
                {
                    playerTurn++;
                }
            }
        }

        public void SortPlayerHands()
        {
            for (int i = 0; i < Hands.Length; i++)
            {
                Hands[i].SortHand();
            }
        }

        public string CreateGameOutput()
        {
            const string basePath = "C:/temp/cardGame";
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }
            var dt = DateTime.Now.ToString("s").Replace("T", "-").Replace(":", "-");
            var path = $"{basePath}/game-{dt}.txt";

            using (var gameFile = File.CreateText(path))
            {
                for (int i = 0; i < Hands.Length; i++)
                {
                    var hand = Hands[i].ToString();
                    var playerInfo = $"Player #{i + 1}: {hand}";
                    gameFile.WriteLine(playerInfo);
                }
            }
            return path;
        }
    }
}
