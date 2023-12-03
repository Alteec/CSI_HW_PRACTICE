using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Six = 0,
            Seven = 1,
            Eight = 2,
            Nine = 3,
            Ten = 4,
            Joker = 5,
            Queen = 6,
            King = 7,
            Ace = 8,
        }

        public class Card
        {
            public Suits Suit { get; }
            public Types Type { get; }

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
    }
