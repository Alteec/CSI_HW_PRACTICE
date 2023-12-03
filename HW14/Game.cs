using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    public class Game
    {
        public List<Player> Players { get; }
        public List<Card> Deck { get; set; }

        public Game(List<Player> players)
        {
            if (players.Count >= 2)
            {
                Players = players;
            }
            else
            {
                throw new ArgumentException();
            }
            Deck = ValidDeck();
        }

        public void Shuffle()
        {
            Random rand = new Random();
            this.Deck = Deck.OrderBy(a => rand.Next()).ToList();
        }

        static public List<Card> ValidDeck()
        {
            List<Card> deck = new List<Card>();
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Types type in Enum.GetValues(typeof(Types)))
                {
                    Card card = new Card(suit, type);
                    deck.Add(card);
                }
            }
            return deck;
        }

        public void Give()
        {
            int player_count = Players.Count();
            int card_count = Deck.Count();
            int cards = card_count / player_count;
            int from = 0;

            foreach (Player player in Players)
            {
                player.Cards = Deck.GetRange(from, cards);
                from += cards;
            }
        }

        public void PrintEachPlayersCards()
        {
            foreach (Player player in Players)
            {
                player.ShowCards();
            }
        }

        private void Turn()
        {
            List<Card> onTable = new List<Card>();
            Random rand = new Random();
            Player max_player = Players[0];
            Card max_card = new Card(Suits.Hearts, Types.Six);
            foreach (Player player in Players)
            {
                int rand_card = rand.Next(0, player.Cards.Count());
                Card placed = player.Cards[rand_card];
                if ((int)placed.Type > (int)max_card.Type)
                {
                    max_card = placed;
                    max_player = player;
                }
                onTable.Add(placed);
                player.Cards.Remove(placed);
            }
            max_player.Cards.AddRange(onTable);
        }

        public void Start()
        {
            while (Players.Count() != 1)
            {
                Console.Clear();
                PrintEachPlayersCards();
                foreach (Player player in Players.ToList())
                {
                    if (player.Cards.Count() == 0)
                    {
                        Players.Remove(player);
                    }
                }
                Turn();
                Thread.Sleep(100);

            }
            Console.WriteLine($"Winner:{Players[0]} ");
        }
    }
}
