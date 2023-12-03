﻿using System;

namespace HW14
{
    public enum Suits
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Types
    {
        Six=0,
        Seven=1,
        Eight=2,
        Nine=3,
        Ten=4,
        Joker = 5,
        Queen = 6,
        King = 7,
        Ace = 8,
    }

    public class Card
    {
        public Suits Suit {  get;  }
        public Types Type { get;  }

        public Card(Suits suit, Types type)
        {
            this.Suit = suit;
            this.Type = type;
        }

        public override string ToString()
        {
            return $"{Suit} {Type}";
        }

    }
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public Player(string Name) {
        
            this.Name = Name;
        }

        public void ShowCards()
        {
            Console.Write($"{Name}: ");

            foreach (var card in Cards)
            {
                Console.Write($"{card},");
            }
            Console.WriteLine("\n");

        }

        public override string ToString()
        {
            return $"{Name}";
        }


    }
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
            
            foreach(Player player in Players)
            {
                player.Cards = Deck.GetRange(from, cards);
                from += cards;
            }
        }

        public void PrintEachPlayersCards()
        {
            foreach(Player player in Players)
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

    class HW14
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("John");
            Player player2 = new Player("Martin");
            Player player3 = new Player("Lee");
            Player player4 = new Player("Paul");


            Game game =new Game(new List<Player> { player1, player2,player3,player4 });
            
            game.Shuffle();
            game.Give();
            game.Start();


        }
    }
}