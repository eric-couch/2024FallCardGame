using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024FallCardGame;

public class Deck
{
    public List<Card> Cards { get; set; } = new List<Card>();

    public int cardsRemaining { get; set; }

    public Deck()
    {
        ResetDeck();
    }

    
    public List<Card> DealCards(int howManyCards)
    {
        List<Card> CardsToDeal = new List<Card>();   
        for (int i = 0; i < howManyCards; i++)
        {
            CardsToDeal.Add(DealCard());
        }
        return CardsToDeal;
    }


    public Card DealCard()
    {
        Random random = new Random();
        int cardToDealIndex = random.Next(cardsRemaining);
        Card cardToDeal = Cards[cardToDealIndex];
        Cards.RemoveAt(cardToDealIndex);
        cardsRemaining--;
        return cardToDeal;
    }

    //public void Shuffle()
    //{
    //    Random rnd = new Random();

    //    for (int i = 0; i < 10000; i++)
    //    {
    //        int rndCardIndex = rnd.Next(cardsRemaining);
    //        List<Card> firstHalf = Cards.Take(rndCardIndex).ToList();
    //        List<Card> secondHalf = Cards.Skip(rndCardIndex).ToList();

    //        List<Card> newDeck = new List<Card>();
    //        newDeck.AddRange(secondHalf);
    //        newDeck.AddRange(firstHalf);

    //        Cards = newDeck;
    //    }
    //}

    public void ResetDeck()
    {
        Cards.Clear();
        List<string> suits = new List<string>() { "♥", "♦", "♣", "♠" };
        List<string> ranks = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        List<int> values = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                Cards.Add(new Card(suit, values[ranks.IndexOf(rank)], rank));
                cardsRemaining++;
            }
        }
    }
}
