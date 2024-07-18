using _2024FallCardGame;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Deck myDeck = new Deck();



List<Card> hand = myDeck.DealCards(5);

foreach (Card card in hand)
{
    Console.WriteLine(card);
}

Console.WriteLine($"Does the hand contain aces?: {(FiveCardDraw.CheckForAces(hand) ? "yes" : "no")}");

//Console.WriteLine($"Does the hand contain pair?: {(FiveCardDraw.CheckForPair(hand) ? "yes" : "no")}");

Console.WriteLine(myDeck.cardsRemaining);

