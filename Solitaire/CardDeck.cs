namespace Solitaire;
public class CardDeck
{
    protected Stack<Card> Cards { get; set; } = new Stack<Card>();
    public int Count
    {
        get
        {
            return Cards.Count;
        }
    }

    public void Add(Card card)
    {
        Cards.Push(card);
    }

    public CardDeck()
    {
        List<Card> cards = new List<Card>();

        foreach (CardSuit suit in (CardSuit[])Enum.GetValues(typeof(CardSuit)))
        {
            foreach (CardValue value in (CardValue[])Enum.GetValues(typeof(CardValue)))
            {
                Card newCard = new Card()
                {
                    Suit = suit,
                    Value = value,
                    DisplayName = $"{value} of {suit}",
                    CardValue = (int)value
                };

                cards.Add(newCard);
            }
        }

        var array = cards.ToArray();

        Random rnd = new Random();

        for (int n = array.Count() - 1; n > 0; --n)
        {
            int k = rnd.Next(n + 1);

            Card temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }

        for (int n = 0; n < array.Count(); n++)
        {
            Cards.Push(array[n]);
        }
    }

    public Card Draw(string location)
    {
        var card = Cards.Pop();
        card.IsVisible = true;
        card.Location = location;
        return card;
    }

    public Card DrawHidden(string location)
    {
        var card = Cards.Pop();
        card.IsVisible = false;
        card.Location = location;
        return card;
    }

    public void PrintDeck()
    {
        Console.Write("[" + Count + "]");
    }

    public string GetCardNameAtPosition(int position)
    {
        try
        {

            List<Card> cards = Cards.ToList();

            if (cards[position].IsVisible)
            {
                return cards[position].DisplayName;
            }
            else
            {
                return "[" + Count + "]";
            }
        }
        catch (global::System.Exception)
        {

            return String.Empty;
        }
    }
}
