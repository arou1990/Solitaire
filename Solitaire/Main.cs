using Solitaire;


CardDeck DrawDeck = new CardDeck();
DiscardPile DiscardPile = new DiscardPile("Discard");

SuitPile ClubsPile = new SuitPile(CardSuit.Clubs, "Clubs");
SuitPile DiamondsPile = new SuitPile(CardSuit.Diamonds, "Diamonds");
SuitPile SpadesPile = new SuitPile(CardSuit.Spades, "Spades");
SuitPile HeartsPile = new SuitPile(CardSuit.Hearts, "Hearts");

StackPile StackPile1 = new StackPile("StackPile1");
StackPile StackPile2 = new StackPile("StackPile2");
StackPile StackPile3 = new StackPile("StackPile3");
StackPile StackPile4 = new StackPile("StackPile4");
StackPile StackPile5 = new StackPile("StackPile5");
StackPile StackPile6 = new StackPile("StackPile6");
StackPile StackPile7 = new StackPile("StackPile7");

StackPile1.Add(DrawDeck.Draw("StackPile1"));
StackPile2.Add(DrawDeck.DrawHidden("StackPile2"));
StackPile3.Add(DrawDeck.DrawHidden("StackPile3"));
StackPile4.Add(DrawDeck.DrawHidden("StackPile4"));
StackPile5.Add(DrawDeck.DrawHidden("StackPile5"));
StackPile6.Add(DrawDeck.DrawHidden("StackPile6"));
StackPile7.Add(DrawDeck.DrawHidden("StackPile7"));

StackPile2.Add(DrawDeck.Draw("StackPile2"));
StackPile3.Add(DrawDeck.DrawHidden("StackPile3"));
StackPile4.Add(DrawDeck.DrawHidden("StackPile4"));
StackPile5.Add(DrawDeck.DrawHidden("StackPile5"));
StackPile6.Add(DrawDeck.DrawHidden("StackPile6"));
StackPile7.Add(DrawDeck.DrawHidden("StackPile7"));


StackPile3.Add(DrawDeck.Draw("StackPile3"));
StackPile4.Add(DrawDeck.DrawHidden("StackPile4"));
StackPile5.Add(DrawDeck.DrawHidden("StackPile5"));
StackPile6.Add(DrawDeck.DrawHidden("StackPile6"));
StackPile7.Add(DrawDeck.DrawHidden("StackPile7"));

StackPile4.Add(DrawDeck.Draw("StackPile4"));
StackPile5.Add(DrawDeck.DrawHidden("StackPile5"));
StackPile6.Add(DrawDeck.DrawHidden("StackPile6"));
StackPile7.Add(DrawDeck.DrawHidden("StackPile7"));

StackPile5.Add(DrawDeck.Draw("StackPile5"));
StackPile6.Add(DrawDeck.DrawHidden("StackPile6"));
StackPile7.Add(DrawDeck.DrawHidden("StackPile7"));

StackPile6.Add(DrawDeck.Draw("StackPile6"));
StackPile7.Add(DrawDeck.DrawHidden("StackPile7"));

StackPile7.Add(DrawDeck.Draw("StackPile7"));

void PrintPiles()
{
    Console.WriteLine(string.Format("{0,-20} {1,-20} {2,-20} {3,-20}", "Clubs", "Spades", "Hearts", "Diamonds"));

    for (int i = 0; i < 19; i++)
    {
        Console.WriteLine(string.Format("{0,-20} {1,-20} {2,-20} {3,-20}", ClubsPile.GetCardNameAtPosition(i), SpadesPile.GetCardNameAtPosition(i),
            HeartsPile.GetCardNameAtPosition(i), DiamondsPile.GetCardNameAtPosition(i)));
    }
    Console.WriteLine("\n");
    Console.WriteLine(string.Format("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20} {5,-20} {6,-20}", "StackPile1", "StackPile2", "StackPile3", "StackPile4", "StackPile5", "StackPile6", "StackPile7"));

    for (int i = 0; i < 19; i++)
    {
        Console.WriteLine(string.Format("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20} {5,-20} {6,-20}", StackPile1.GetCardNameAtPosition(i),
            StackPile2.GetCardNameAtPosition(i), StackPile3.GetCardNameAtPosition(i), StackPile4.GetCardNameAtPosition(i), 
            StackPile5.GetCardNameAtPosition(i), StackPile6.GetCardNameAtPosition(i), StackPile7.GetCardNameAtPosition(i)));
    }
    Console.WriteLine(string.Format("{0,-20} {1,-20}", "Draw", "Discard"));

    for (int i = 0; i < 25; i++)
    {
        Console.WriteLine(string.Format("{0,-20} {1,-20}", DrawDeck.GetCardNameAtPosition(i), DiscardPile.GetCardNameAtPosition(i)));
    }
}

bool CanMoveCardToStackPile(Card sourceCard, StackPile targetPile)
{
    Card lastTargetCard = targetPile.Last();
    if(lastTargetCard == null)
    {
        return true;
    }
    if(sourceCard.IsRed && lastTargetCard.IsBlack)
    {
        return true;
    }
    if (sourceCard.IsBlack && lastTargetCard.IsRed)
    {
        return true;
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

void RemoveCardFromPile(string pileName, Card sourceCard, PileBase targetPile)
{
    if(pileName == "Clubs")
    {
        sourceCard.Location = targetPile.Location;
        targetPile.Add(sourceCard);
        ClubsPile.RemoveIfExists(sourceCard);
    }
    if (pileName == "Spades")
    {
        sourceCard.Location = targetPile.Location;
        targetPile.Add(sourceCard);
        SpadesPile.RemoveIfExists(sourceCard);
    }
    if (pileName == "Hearts")
    {
        sourceCard.Location = targetPile.Location;
        targetPile.Add(sourceCard);
        HeartsPile.RemoveIfExists(sourceCard);
    }
    if (pileName == "Diamonds")
    {
        sourceCard.Location = targetPile.Location;
        targetPile.Add(sourceCard);
        DiamondsPile.RemoveIfExists(sourceCard);
    }
    if (pileName == "StackPile1")
    {
        int currentIndex = StackPile1.IndexOf(sourceCard);
        int lastIndex = StackPile1.Count() - currentIndex;
        List<Card> slicedCards = StackPile1.Cards.GetRange(currentIndex, lastIndex);

        foreach (Card card in slicedCards)
        {
            sourceCard.Location = targetPile.Location;
            targetPile.Add(card);
            StackPile1.RemoveIfExists(card);
            StackPile1.ShowLast();
        }
    }
    if (pileName == "StackPile2")
    {
        int currentIndex = StackPile2.IndexOf(sourceCard);
        int lastIndex = StackPile2.Count() - currentIndex;
        List<Card> slicedCards = StackPile2.Cards.GetRange(currentIndex, lastIndex);

        foreach (Card card in slicedCards)
        {
            sourceCard.Location = targetPile.Location;
            targetPile.Add(card);
            StackPile2.RemoveIfExists(card);
            StackPile2.ShowLast();
        }
    }
    if (pileName == "StackPile3")
    {
        int currentIndex = StackPile3.IndexOf(sourceCard);
        int lastIndex = StackPile3.Count() - currentIndex;
        List<Card> slicedCards = StackPile3.Cards.GetRange(currentIndex, lastIndex);

        foreach (Card card in slicedCards)
        {
            sourceCard.Location = targetPile.Location;
            targetPile.Add(card);
            StackPile3.RemoveIfExists(card);
            StackPile3.ShowLast();
        }
    }
    if (pileName == "StackPile4")
    {
        int currentIndex = StackPile4.IndexOf(sourceCard);
        int lastIndex = StackPile4.Count() - currentIndex;
        List<Card> slicedCards = StackPile4.Cards.GetRange(currentIndex, lastIndex);

        foreach (Card card in slicedCards)
        {
            sourceCard.Location = targetPile.Location;
            targetPile.Add(card);
            StackPile4.RemoveIfExists(card);
            StackPile4.ShowLast();
        }
    }
    if (pileName == "StackPile5")
    {
        int currentIndex = StackPile5.IndexOf(sourceCard);
        int lastIndex = StackPile5.Count() - currentIndex;
        List<Card> slicedCards = StackPile5.Cards.GetRange(currentIndex, lastIndex);

        foreach (Card card in slicedCards)
        {
            sourceCard.Location = targetPile.Location;
            targetPile.Add(card);
            StackPile5.RemoveIfExists(card);
            StackPile5.ShowLast();
        }
    }
    if (pileName == "StackPile6")
    {
        int currentIndex = StackPile6.IndexOf(sourceCard);
        int lastIndex = StackPile6.Count() - currentIndex;
        List<Card> slicedCards = StackPile6.Cards.GetRange(currentIndex, lastIndex);

        foreach (Card card in slicedCards)
        {
            sourceCard.Location = targetPile.Location;
            targetPile.Add(card);
            StackPile6.RemoveIfExists(card);
            StackPile6.ShowLast();
        }
    }
    if (pileName == "StackPile7")
    {
        int currentIndex = StackPile7.IndexOf(sourceCard);
        int lastIndex = StackPile7.Count() - currentIndex;
        List<Card> slicedCards = StackPile7.Cards.GetRange(currentIndex, lastIndex);

        foreach (Card card in slicedCards)
        {
            sourceCard.Location = targetPile.Location;
            targetPile.Add(card);
            StackPile7.RemoveIfExists(card);
            StackPile7.ShowLast();
        }
    }
    if (pileName == "Discard")
    {
        if (DiscardPile.Last() == sourceCard) 
        {
            sourceCard.Location = targetPile.Location;
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

void AddToPile(string location)
{
    if(location == "StackPile1")
    {

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

bool gameStatus = false;
while (!gameStatus)
{
    Console.Clear();

    Console.WriteLine(
    "*Solitaire*\n" +
    "Stack Piles are named StackPile1 through StackPile7 from left to right\n" +
    "Suit Piles are named Clubs, Spades, Hearts, Diamonds\n" +
    "Discard Pile is named Discard Pile\n" +
    "Type draw to draw a card\n" +
    "Type move (cardname) to (pilename) to move a card\n" +
    "Good Luck!\n\n\n\n"
    );

    PrintPiles();
    Console.Write("\n");
    Console.Write("Please enter your action: ");
    string action = Console.ReadLine();

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
                    RemoveCardFromPile(currentCard.Location, currentCard, ClubsPile);
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
                    RemoveCardFromPile(currentCard.Location, currentCard, HeartsPile);
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
                    RemoveCardFromPile(currentCard.Location, currentCard, DiamondsPile);
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
                    RemoveCardFromPile(currentCard.Location, currentCard, SpadesPile);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "Spades");
                }
            }
            if (cardPile == "StackPile1")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile1))
                {
                    RemoveCardFromPile(currentCard.Location, currentCard, StackPile1);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "StackPile1");
                }
            }
            if (cardPile == "StackPile2")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile2))
                {
                    RemoveCardFromPile(currentCard.Location, currentCard, StackPile2);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "StackPile2");
                }
            }
            if (cardPile == "StackPile3")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile3))
                {
                    RemoveCardFromPile(currentCard.Location, currentCard, StackPile3);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "StackPile3");
                }
            }
            if (cardPile == "StackPile4")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile4))
                {
                    RemoveCardFromPile(currentCard.Location, currentCard, StackPile4);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "StackPile4");
                }
            }
            if (cardPile == "StackPile5")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile5))
                {
                    RemoveCardFromPile(currentCard.Location, currentCard, StackPile5);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "StackPile5");
                }
            }
            if (cardPile == "StackPile6")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile6))
                {
                    RemoveCardFromPile(currentCard.Location, currentCard, StackPile6);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "StackPile6");
                }
            }
            if (cardPile == "StackPile7")
            {

                if (CanMoveCardToStackPile(currentCard, StackPile7))
                {
                    RemoveCardFromPile(currentCard.Location, currentCard, StackPile7);
                }
                else
                {
                    IllegalMove(currentCard.DisplayName, "StackPile7");
                }
            }
        }
    }
    else
    {
        Console.WriteLine("You skipped your turn");
    }
}
















