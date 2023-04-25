using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire;
    public class SuitPile : PileBase
    {
        public CardSuit Suit { get; set; }

        public CardValue AllowedValue
        {
            get
            {
                var topCard = Last();
                if (topCard == null) return CardValue.Ace;

                int currentValue = (int)topCard.Value;
                return (CardValue)(currentValue + 1);
            }
        }

        public SuitPile(CardSuit suit, string location) : base(location)
        {
            Suit = suit;
        }

        public bool IsComplete
        {
            get
            {
                return (int)AllowedValue == 14;
            }
        }
    }
