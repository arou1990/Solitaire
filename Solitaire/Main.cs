using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solitaire;


CardDeck DrawDeck = new CardDeck();

DiscardPile DiscardPile = new DiscardPile("Discard Pile");

SuitPile ClubsPile = new SuitPile(CardSuit.Clubs, "ClubsPile");
SuitPile DiamondsPile = new SuitPile(CardSuit.Diamonds, "DiamondsPile");
SuitPile SpadesPile = new SuitPile(CardSuit.Spades, "SpadesPile");
SuitPile HeartsPile = new SuitPile(CardSuit.Hearts, "HeartsPile");

StackPile StackPile1 = new StackPile("StackPile1");
StackPile StackPile2 = new StackPile("StackPile2");
StackPile StackPile3 = new StackPile("StackPile3");
StackPile StackPile4 = new StackPile("StackPile4");
StackPile StackPile5 = new StackPile("StackPile5");
StackPile StackPile6 = new StackPile("StackPile6");
StackPile StackPile7 = new StackPile("StackPile7");

Card card = new Card();

DrawDeck = new CardDeck();
DiscardPile = new DiscardPile("DiscardPile");

ClubsPile = new SuitPile(CardSuit.Clubs, "ClubsPile");
DiamondsPile = new SuitPile(CardSuit.Diamonds, "DiamondsPile");
SpadesPile = new SuitPile(CardSuit.Spades, "SpadesPile");
HeartsPile = new SuitPile(CardSuit.Hearts, "HeartsPile");

StackPile1 = new StackPile("StackPile1");
StackPile2 = new StackPile("StackPile2");
StackPile3 = new StackPile("StackPile3");
StackPile4 = new StackPile("StackPile4");
StackPile5 = new StackPile("StackPile5");
StackPile6 = new StackPile("StackPile6");
StackPile7 = new StackPile("StackPile7");

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
    "Stack Piles are named StackPile1 through StackPile7 from left to right" + Environment.NewLine +
    "Suit Piles are named Clubs, Spades, Hearts, Diamonds" + Environment.NewLine +
    "Discard Pile is named Discard Pile" + Environment.NewLine +
    "Type draw to draw a card" + Environment.NewLine +
    "Type move (cardname) to (pilename) to move a card" + Environment.NewLine +
    "Good Luck!"
    );

Console.WriteLine(" " + Environment.NewLine);



Console.WriteLine(Environment.NewLine);


DrawDeck.PrintDeck();
DiscardPile.PrintEmptyPile();
ClubsPile.PrintEmptyPile();
SpadesPile.PrintEmptyPile();
HeartsPile.PrintEmptyPile();
DiamondsPile.PrintEmptyPile();




Console.WriteLine(" " + Environment.NewLine);


Console.Write("Please enter your move: ");
string move = Console.ReadLine();




if (move == "draw")
{
    DiscardPile.Add(DrawDeck.Draw());
}
else if (move == $"{card.DisplayName} to Clubs")
{
    List<Card> temp = new List<Card>();
    temp.Add(card);
    ClubsPile.Add(temp.Pop);

}
else if (move == $"{card.DisplayName} to Spades")
{
    List<Card> temp = new List<Card>();
    temp.Add(card);
    SpadesPile.Add(temp.Pop);

}
else if (move == $"{card.DisplayName} to Hearts")
{
    List<Card> temp = new List<Card>();
    temp.Add(card);
    HeartsPile.Add(temp.Pop);

}
else if (move == $"{card.DisplayName} to Diamonds")
{
    List<Card> temp = new List<Card>();
    temp.Add(card);
    DiamondsPile.Add(temp.Pop);

}
else if (move == $"{card.DisplayName} to StackPile1")
{
    foreach()

}









Console.Read();
















