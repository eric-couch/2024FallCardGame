﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2024FallCardGame
{
    public class FiveCardDraw
    {
        public static bool CheckForAces(List<Card> cards)
        {
            return cards.Any(card => card.rank == "A");
            //return cards.Exists(card => card.rank == "A");

            //return (from card in cards
            //        where card.rank == "A"
            //        select card).Count() > 0;

            //return cards.Select(card => card.rank).Contains("A");

            //return (from card in cards
            //        where card.rank == "A"
            //        select card).Any();

        }

        public static bool? CheckForPair(List<Card> cards)
        {
            //return (from card in cards
            //        group card by card.rank into g
            //        select g.Count() == 2).Any();
            var group = cards.GroupBy(card => card.value);

            bool? res = group.Any(group => group.Count() == 2);

            return res;
        }

        public static bool IsFlush(List<Card> cards)
        {
            return cards.GroupBy(card => card.suit)
                        .Select(g => g.Count() == 5)
                        .Any();

            //return cards.GroupBy(card => card.suit)
            //            .Any(group => group.Count() == 5);

            //return (from card in cards
            //        group card by card.suit into g
            //        select g).Count() == 1;

            //return cards.Select(cards => cards.suit)
            //            .Distinct().Count() == 1;


        }

    }
}