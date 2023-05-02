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
    public void ShowLast()
    {
        Card lastCard = Cards.LastOrDefault();
        if (lastCard != null)
        {
            lastCard.IsVisible = true;
        }
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
    public Card GetCard(string displayName)
    {
        List<Card> matchingCards = Cards.Where(x => x.DisplayName == displayName).ToList();
        if (matchingCards.Count > 0)
        {
            return matchingCards[0];
        }
        return null;
    }
    public void PrintCard()
    {
        Console.Write(Cards[Cards.Count - 1].DisplayName);
    }
    public void PrintPile()
    {
        foreach (Card card in Cards)
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
        if (Cards.Count == 0)
        {
            Console.Write("+");
        }
    }
    public int IndexOf(Card card)
    {
        var matchingCard = Cards.FirstOrDefault(x => x.Suit == card.Suit && x.Value == card.Value);
        if (matchingCard != null)
            return Cards.IndexOf(matchingCard);

        return 0;
    }
    public string GetCardNameAtPosition(int position)
    {
        try
        {
            if (Cards[position].IsVisible)
            {
                return Cards[position].DisplayName;
            }
            else
            {
                return "[X]";
            }
        }
        catch (global::System.Exception)
        {

            return String.Empty;
        }
    }
}
