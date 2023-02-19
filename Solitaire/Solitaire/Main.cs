using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solitaire;


CardDeck DrawDeck = new CardDeck();

DiscardPile DiscardPile = new DiscardPile();

SuitPile ClubsPile = new SuitPile(CardSuit.Clubs);
SuitPile DiamondsPile = new SuitPile(CardSuit.Diamonds);
SuitPile SpadesPile = new SuitPile(CardSuit.Spades);
SuitPile HeartsPile = new SuitPile(CardSuit.Hearts);

StackPile StackPile1 = new StackPile();
StackPile StackPile2 = new StackPile();
StackPile StackPile3 = new StackPile();
StackPile StackPile4 = new StackPile();
StackPile StackPile5 = new StackPile();
StackPile StackPile6 = new StackPile();
StackPile StackPile7 = new StackPile();

Card card = new Card();

DrawDeck = new CardDeck();
DiscardPile = new DiscardPile();

ClubsPile = new SuitPile(CardSuit.Clubs);
DiamondsPile = new SuitPile(CardSuit.Diamonds);
SpadesPile = new SuitPile(CardSuit.Spades);
HeartsPile = new SuitPile(CardSuit.Hearts);

StackPile1 = new StackPile();
StackPile2 = new StackPile();
StackPile3 = new StackPile();
StackPile4 = new StackPile();
StackPile5 = new StackPile();
StackPile6 = new StackPile();
StackPile7 = new StackPile();

StackPile1.Add(DrawDeck.Draw());
StackPile2.Add(DrawDeck.DrawHidden());
StackPile3.Add(DrawDeck.DrawHidden());
StackPile4.Add(DrawDeck.DrawHidden());
StackPile5.Add(DrawDeck.DrawHidden());
StackPile6.Add(DrawDeck.DrawHidden());
StackPile7.Add(DrawDeck.DrawHidden());

StackPile2.Add(DrawDeck.Draw());
StackPile3.Add(DrawDeck.DrawHidden());
StackPile4.Add(DrawDeck.DrawHidden());
StackPile5.Add(DrawDeck.DrawHidden());
StackPile6.Add(DrawDeck.DrawHidden());
StackPile7.Add(DrawDeck.DrawHidden());

StackPile3.Add(DrawDeck.Draw());
StackPile4.Add(DrawDeck.DrawHidden());
StackPile5.Add(DrawDeck.DrawHidden());
StackPile6.Add(DrawDeck.DrawHidden());
StackPile7.Add(DrawDeck.DrawHidden());

StackPile4.Add(DrawDeck.Draw());
StackPile5.Add(DrawDeck.DrawHidden());
StackPile6.Add(DrawDeck.DrawHidden());
StackPile7.Add(DrawDeck.DrawHidden());

StackPile5.Add(DrawDeck.Draw());
StackPile6.Add(DrawDeck.DrawHidden());
StackPile7.Add(DrawDeck.DrawHidden());

StackPile6.Add(DrawDeck.Draw());
StackPile7.Add(DrawDeck.DrawHidden());

StackPile7.Add(DrawDeck.Draw());

Console.WriteLine(
    "*Solitaire*" + Environment.NewLine +
    "Type draw to draw a card" + Environment.NewLine +
    "Type move (cardname) to (cardname) to move a card" + Environment.NewLine +
    "Good Luck!"
    );

Console.WriteLine(" " + Environment.NewLine);

DrawDeck.PrintDeck();
Console.Write("  ");
DiscardPile.PrintEmptyPile();
Console.WriteLine(" " + Environment.NewLine);

Console.Write("Please enter your move: ");

string move = Console.ReadLine();

Console.WriteLine(" ");

if (move == "draw")
{
    DiscardPile.Add(DrawDeck.Draw());
    DrawDeck.PrintDeck();
    Console.Write("  ");
    DiscardPile.PrintCard();
}
else if (move == $"{card.DisplayName} to {card.DisplayName}")
{

}









Console.Read();









void DrawCard()
{
    if(DiscardPile.Count > 0)
    {
        DiscardPile.HideShowCard(false);
    }
    DiscardPile.Add(DrawDeck.Draw());
    DiscardPile.HideShowCard(true);
}

void ResetDrawPile()
{
    var allCards = DiscardPile.GetAll();
    allCards.Reverse();
    foreach (var card in allCards)
    {
        DrawDeck.Add(card);
    }
    DiscardPile = new DiscardPile();
}









