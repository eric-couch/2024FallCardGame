using _2024FallCardGame;

namespace _2024FallCardGame.Test;

public class UnitTest1
{
    [Fact]
    public void TestCheckForAces_True()
    {
        List<Card> cards = new List<Card>() {   new Card("♣", 8, "8"),
                                                new Card("♠", 14, "A"),
                                                new Card("♦", 4, "4"),
                                                new Card("♦", 5, "5"),
                                                new Card("♥", 2, "2") };

        bool aceInHand = FiveCardDraw.CheckForAces(cards);
        Assert.True(aceInHand);
    }

    [Fact]
    public void TestCheckForAces_False()
    {
        // Arrange
        List<Card> cards = new List<Card>() {   new Card("♣", 8, "8"),
                                                new Card("♠", 13, "K"),
                                                new Card("♦", 4, "4"),
                                                new Card("♦", 5, "5"),
                                                new Card("♥", 2, "2") };

        // Act
        bool aceInHand = FiveCardDraw.CheckForAces(cards);

        // Assert 
        Assert.False(aceInHand);
    }

    [Fact]
    public void TestCheckForPair_True()
    {
        List<Card> cards = new List<Card>() {   new Card("♣", 8, "8"),
                                                new Card("♠", 8, "8"),
                                                new Card("♦", 4, "4"),
                                                new Card("♦", 5, "5"),
                                                new Card("♥", 2, "2") };

        bool? pairInHand = FiveCardDraw.CheckForPair(cards);
        Assert.True(pairInHand);
    }

    [Fact]
    public void TestCheckForPair_False()
    {
        List<Card> cards = new List<Card>() {   new Card("♣", 8, "8"),
                                                new Card("♠", 12, "Q"),
                                                new Card("♦", 4, "4"),
                                                new Card("♦", 5, "5"),
                                                new Card("♥", 2, "2") };

        bool? pairInHand = FiveCardDraw.CheckForPair(cards);
        Assert.False(pairInHand);
    }
}