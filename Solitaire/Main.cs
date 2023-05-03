using Solitaire;


CardDeck DrawDeck = new CardDeck();
DiscardPile DiscardPile = new DiscardPile("Discard");

SuitPile ClubsPile = new SuitPile(CardSuit.Clubs, "Clubs");
SuitPile DiamondsPile = new SuitPile(CardSuit.Diamonds, "Diamonds");
SuitPile SpadesPile = new SuitPile(CardSuit.Spades, "Spades");
SuitPile HeartsPile = new SuitPile(CardSuit.Hearts, "Hearts");

StackPile StackPile1 = new StackPile("Pile1");
StackPile StackPile2 = new StackPile("Pile2");
StackPile StackPile3 = new StackPile("Pile3");
StackPile StackPile4 = new StackPile("Pile4");
StackPile StackPile5 = new StackPile("Pile5");
StackPile StackPile6 = new StackPile("Pile6");
StackPile StackPile7 = new StackPile("Pile7");

StackPile1.Add(DrawDeck.Draw("Pile1"));
StackPile2.Add(DrawDeck.DrawHidden("Pile2"));
StackPile3.Add(DrawDeck.DrawHidden("Pile3"));
StackPile4.Add(DrawDeck.DrawHidden("Pile4"));
StackPile5.Add(DrawDeck.DrawHidden("Pile5"));
StackPile6.Add(DrawDeck.DrawHidden("Pile6"));
StackPile7.Add(DrawDeck.DrawHidden("Pile7"));

StackPile2.Add(DrawDeck.Draw("Pile2"));
StackPile3.Add(DrawDeck.DrawHidden("Pile3"));
StackPile4.Add(DrawDeck.DrawHidden("Pile4"));
StackPile5.Add(DrawDeck.DrawHidden("Pile5"));
StackPile6.Add(DrawDeck.DrawHidden("Pile6"));
StackPile7.Add(DrawDeck.DrawHidden("Pile7"));


StackPile3.Add(DrawDeck.Draw("Pile3"));
StackPile4.Add(DrawDeck.DrawHidden("Pile4"));
StackPile5.Add(DrawDeck.DrawHidden("Pile5"));
StackPile6.Add(DrawDeck.DrawHidden("Pile6"));
StackPile7.Add(DrawDeck.DrawHidden("Pile7"));

StackPile4.Add(DrawDeck.Draw("Pile4"));
StackPile5.Add(DrawDeck.DrawHidden("Pile5"));
StackPile6.Add(DrawDeck.DrawHidden("Pile6"));
StackPile7.Add(DrawDeck.DrawHidden("Pile7"));

StackPile5.Add(DrawDeck.Draw("Pile5"));
StackPile6.Add(DrawDeck.DrawHidden("Pile6"));
StackPile7.Add(DrawDeck.DrawHidden("Pile7"));

StackPile6.Add(DrawDeck.Draw("Pile6"));
StackPile7.Add(DrawDeck.DrawHidden("Pile7"));

StackPile7.Add(DrawDeck.Draw("Pile7"));

void PrintPiles()
{
    Console.WriteLine(string.Format("{0,-20} {1,-20}", "Draw", "Discard"));
    Console.WriteLine(string.Format("{0,-20} {1,-20}\n\n", DrawDeck.Count, DiscardPile.GetCardNameAtPosition(DiscardPile.Count - 1)));

    Console.WriteLine(string.Format("{0,-20} {1,-20} {2,-20} {3,-20}", "♣Clubs♣", "♠Spades♠", "♥Hearts♥", "♦Diamonds♦"));

    for (int i = 0; i < 15; i++)
    {
        Console.WriteLine(string.Format("{0,-20} {1,-20} {2,-20} {3,-20}", ClubsPile.GetCardNameAtPosition(i), SpadesPile.GetCardNameAtPosition(i),
            HeartsPile.GetCardNameAtPosition(i), DiamondsPile.GetCardNameAtPosition(i)));
    }
    Console.WriteLine("\n");
    Console.WriteLine(string.Format("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20} {5,-20} {6,-20}", "Pile1", "Pile2", "Pile3", "Pile4", "Pile5", "Pile6", "Pile7"));

    for (int i = 0; i < 15; i++)
    {
        Console.WriteLine(string.Format("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20} {5,-20} {6,-20}", StackPile1.GetCardNameAtPosition(i),
            StackPile2.GetCardNameAtPosition(i), StackPile3.GetCardNameAtPosition(i), StackPile4.GetCardNameAtPosition(i), 
            StackPile5.GetCardNameAtPosition(i), StackPile6.GetCardNameAtPosition(i), StackPile7.GetCardNameAtPosition(i)));
    }
}

bool CanMoveCardToStackPile(Card sourceCard, StackPile targetPile)
{
    Card lastTargetCard = targetPile.Last();
    if(lastTargetCard == null)
    {
        return true;
    }
    else
    {
        if(lastTargetCard.CardValue - 1 == sourceCard.CardValue)
        {
            if (sourceCard.IsRed && lastTargetCard.IsBlack)
            {
                return true;
            }
            if (sourceCard.IsBlack && lastTargetCard.IsRed)
            {
                return true;
            }
        }
    }
    return false;
}

bool CanMoveCardToSuitPile(Card sourceCard, SuitPile targetPile)
{
    CardSuit targetCardSuit = targetPile.Suit;
    if (sourceCard.Suit == targetCardSuit)
    {
        int cardValue = (int)targetPile.AllowedValue;
        if(cardValue == sourceCard.CardValue){ 
            return true; 
        }
    }
    return false;
}

void IllegalMove(string displayName, string pileName)
{
    Console.WriteLine(string.Format("Could Not Move {0} to {1}", displayName, pileName));
    Console.ReadLine();
}

void MoveCard(string pileName, Card sourceCard, PileBase targetPile)
{
    if(pileName == "Clubs" || pileName == "Spades" || pileName == "Hearts" || pileName == "Diamonds")
    {
        sourceCard.Location = targetPile.Location;
        targetPile.Add(sourceCard);
        ClubsPile.RemoveIfExists(sourceCard);
    }

    if (pileName == "Pile1")
    {
        MoveCardPile(sourceCard, targetPile, StackPile1);
    }
    if (pileName == "Pile2")
    {
        MoveCardPile(sourceCard, targetPile, StackPile2);
    }
    if (pileName == "Pile3")
    {
        MoveCardPile(sourceCard, targetPile, StackPile3);
    }
    if (pileName == "Pile4")
    {
        MoveCardPile(sourceCard, targetPile, StackPile4);
    }
    if (pileName == "Pile5")
    {
        MoveCardPile(sourceCard, targetPile, StackPile5);
    }
    if (pileName == "Pile6")
    {
        MoveCardPile(sourceCard, targetPile, StackPile6);
    }
    if (pileName == "Pile7")
    {
        MoveCardPile(sourceCard, targetPile, StackPile7);
    }
    if (pileName == "Discard")
    {
        if (DiscardPile.Last() == sourceCard) 
        {
            sourceCard.Location = targetPile.Location;
            targetPile.Add(sourceCard);
            DiscardPile.RemoveIfExists(sourceCard);
            DiscardPile.ShowLast();
        }
        else
        {
            Console.WriteLine("Card is not last in Pile");
            Console.Read();
        }
    }
}

void MoveCardPile(Card sourceCard, PileBase targetPile, StackPile stackPile)
{
    int currentIndex = stackPile.IndexOf(sourceCard);
    int lastIndex = stackPile.Count() - currentIndex;
    List<Card> slicedCards = stackPile.Cards.GetRange(currentIndex, lastIndex);

    foreach (Card card in slicedCards)
    {
        sourceCard.Location = targetPile.Location;
        targetPile.Add(card);
        stackPile.RemoveIfExists(card);
        stackPile.ShowLast();
    }
}

Card FindMyCard(string displayName)
{
    Card foundSP1 = StackPile1.GetCard(displayName);
    if(foundSP1 != null)
    {
        return foundSP1;
    }
    Card foundSP2 = StackPile2.GetCard(displayName);
    if (foundSP2 != null)
    {
        return foundSP2;
    }
    Card foundSP3 = StackPile3.GetCard(displayName);
    if (foundSP3 != null)
    {
        return foundSP3;
    }
    Card foundSP4 = StackPile4.GetCard(displayName);
    if (foundSP4 != null)
    {
        return foundSP4;
    }
    Card foundSP5 = StackPile5.GetCard(displayName);
    if (foundSP5 != null)
    {
        return foundSP5;
    }
    Card foundSP6 = StackPile6.GetCard(displayName);
    if (foundSP6 != null)
    {
        return foundSP6;
    }
    Card foundSP7 = StackPile7.GetCard(displayName);
    if (foundSP7 != null)
    {
        return foundSP7;
    }
    Card foundDiscard = DiscardPile.GetCard(displayName);
    if (foundDiscard != null)
    {
        return foundDiscard;
    }
    return null;
}

bool ContinueGame()
{
    bool pile1Finished = StackPile1.Cards.Where(card => card.IsVisible == false).ToList().Count == 0 ? true : false;
    bool pile2Finished = StackPile2.Cards.Where(card => card.IsVisible == false).ToList().Count == 0 ? true : false;
    bool pile3Finished = StackPile3.Cards.Where(card => card.IsVisible == false).ToList().Count == 0 ? true : false;
    bool pile4Finished = StackPile4.Cards.Where(card => card.IsVisible == false).ToList().Count == 0 ? true : false;
    bool pile5Finished = StackPile5.Cards.Where(card => card.IsVisible == false).ToList().Count == 0 ? true : false;
    bool pile6Finished = StackPile6.Cards.Where(card => card.IsVisible == false).ToList().Count == 0 ? true : false;
    bool pile7Finished = StackPile7.Cards.Where(card => card.IsVisible == false).ToList().Count == 0 ? true : false;
    if(pile1Finished && pile2Finished && pile3Finished && pile4Finished && pile5Finished && pile6Finished && pile7Finished)
    {
        return false;
    }
    return true;
}

bool gameStatus = true;
while (gameStatus)
{
    Console.Clear();

    Console.WriteLine(
    "*Solitaire*\n" +
    "Stack Piles are named Pile1 through Pile7 from left to right\n" +
    "Suit Piles are named Clubs, Spades, Hearts, Diamonds\n" +
    "Discard Pile is named Discard Pile\n" +
    "Actions: Type draw to draw a card or move to move a card\n" +
    "Type card name for card to move\n" +
    "Type pile name for pile to move to\n" +
    "If all cards are visible, type win to win the game\n" +
    "EVERYTHING IS CASE SENSITIVE\n" +
    "Good Luck!\n\n\n\n"
    );

    PrintPiles();
    Console.Write("\n");
    Console.Write("Please enter your action: ");
    string action = Console.ReadLine();

    if(action == "win")
    {
        gameStatus = ContinueGame();
        if (gameStatus == true)
        {
            Console.WriteLine("You Still Have Unrevealed Cards");
        }
    }

    if (action == "draw")
    {
        if(DrawDeck.Count > 0) {
        DiscardPile.Add(DrawDeck.Draw("Discard"));
        }
        else
        {
             List<Card> reverseDiscard = DiscardPile.GetAll();
             reverseDiscard.Reverse();
             foreach (Card card in reverseDiscard)
            {
                card.IsVisible = false;
                card.Location = "DrawDeck";
                DrawDeck.Add(card);
            }
             DiscardPile.Cards.Clear();
        }
    }
    else if (action == "move")
    {
        Console.Write("Please enter your card name: ");
        string cardName = Console.ReadLine();
        Card currentCard = FindMyCard(cardName);
        if (currentCard == null)
        {
            Console.WriteLine("Card was not found.  Please enter correct card name");
            Console.ReadLine();
        }
        else 
        {
            Console.Write("Please enter your pile name: ");
            string cardPile = Console.ReadLine();
            if (cardPile == "Clubs")
            {

                if (CanMoveCardToSuitPile(currentCard, ClubsPile))
                {
                    MoveCard(currentCard.Location, currentCard, ClubsPile);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "Clubs");
                }
            }
            else if (cardPile == "Hearts")
            {
                if (CanMoveCardToSuitPile(currentCard, HeartsPile))
                {
                    MoveCard(currentCard.Location, currentCard, HeartsPile);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "Hearts");
                }
            }
            else if (cardPile == "Diamonds")
            {
                if (CanMoveCardToSuitPile(currentCard, DiamondsPile))
                {
                    MoveCard(currentCard.Location, currentCard, DiamondsPile);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "Diamonds");
                }
            }
            else if (cardPile == "Spades")
            {
                if (CanMoveCardToSuitPile(currentCard, SpadesPile))
                {
                    MoveCard(currentCard.Location, currentCard, SpadesPile);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "Spades");
                }
            }
            if (cardPile == "Pile1")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile1))
                {
                    MoveCard(currentCard.Location, currentCard, StackPile1);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "Pile1");
                }
            }
            if (cardPile == "Pile2")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile2))
                {
                    MoveCard(currentCard.Location, currentCard, StackPile2);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "Pile2");
                }
            }
            if (cardPile == "Pile3")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile3))
                {
                    MoveCard(currentCard.Location, currentCard, StackPile3);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "Pile3");
                }
            }
            if (cardPile == "Pile4")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile4))
                {
                    MoveCard(currentCard.Location, currentCard, StackPile4);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "Pile4");
                }
            }
            if (cardPile == "Pile5")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile5))
                {
                    MoveCard(currentCard.Location, currentCard, StackPile5);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "Pile5");
                }
            }
            if (cardPile == "Pile6")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile6))
                {
                    MoveCard(currentCard.Location, currentCard, StackPile6);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "Pile6");
                }
            }
            if (cardPile == "Pile7")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile7))
                {
                    MoveCard(currentCard.Location, currentCard, StackPile7);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "Pile7");
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid Move");
        Console.ReadLine();
    }
    if(ClubsPile.Count == 13 && SpadesPile.Count == 13 && HeartsPile.Count == 13 && DiamondsPile.Count == 13)
    {
        gameStatus = false;
    }
}
Console.Clear();
Console.WriteLine("You Win!");
















