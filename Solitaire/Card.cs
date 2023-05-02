using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    public class Card
    {
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }
        public bool IsVisible { get; set; }
        public string DisplayName { get; set; }
        public string Location { get; set; }



        public bool IsRed
        {
            get
            {
                return Suit == CardSuit.Diamonds || Suit == CardSuit.Hearts;
            }
        }

        public bool IsBlack
        {
            get
            {
                return !IsRed;
            }
        }
        public int CardValue { get; set; }
    }
}

