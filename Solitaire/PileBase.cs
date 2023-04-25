using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire;
public class PileBase
{
    public string Location { get; set; }
    public List<Card> Cards { get; set; } = new List<Card>();

    public PileBase(string location)
    {
        Location = location;
    }



    public int Count
    {
        get
        {
            return Cards.Count;
        }
    }

    public void Add(Card card)
    {
        if (card != null)
        {
            card.Location = Location;
            Cards.Add(card);
        }
    }

    public bool Any()
    {
        return Cards.Any();
    }

    public Card Pop()
    {
        var lastCard = Cards.LastOrDefault();
        if (lastCard != null)
        {
            Cards.Remove(lastCard);
        }

        return lastCard;
    }

    public Card Last()
    {
        return Cards.LastOrDefault();
    }

    public void RemoveIfExists(Card card)
    {
        var matchingCard = Cards.FirstOrDefault(x => x.Suit == card.Suit && x.Value == card.Value);
        if (matchingCard != null)
            Cards.Remove(matchingCard);
    }

    public bool Contains(Card card)
    {
        return Cards.Any(x => x.Suit == card.Suit && x.Value == card.Value);
    }

    public void PrintCard()
    {
        Console.Write(Cards[Cards.Count - 1].DisplayName);
    }

    public void PrintPile()
    {
        foreach(Card card in Cards)
        {
            if (card.IsVisible)
            {
                Console.WriteLine(card.DisplayName);
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
    }

    public void PrintEmptyPile()
    {
        if(Cards.Count == 0)
        {
            Console.Write("+");
        }
    }

    
}
