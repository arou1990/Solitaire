﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire;

    public class StackPile : PileBase
    {
        public int IndexOf(Card card)
        {
            var matchingCard = Cards.FirstOrDefault(x => x.Suit == card.Suit && x.Value == card.Value);
            if (matchingCard != null)
                return Cards.IndexOf(matchingCard);

            return 0;
        }

        public bool HasNoHiddenCards()
        {
            return !Any() || Cards.All(x => x.IsVisible);
        }

        public int Count()
        {
            return Cards.Count();
        }

        public List<Card> GetAllCards()
        {
            return Cards;
        }
    }
