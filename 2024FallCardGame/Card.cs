using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024FallCardGame
{
    public class Card
    {
        public string suit { get; set; }
        public string color { get; set; }
        public int value { get; set; }
        public string rank { get; set; }

        /// <summary>
        /// Card class constructor
        /// </summary>
        /// <param name="suit">♣, ♦, ♥, ♠</param>
        /// <param name="value">2, 3, 4...10, 11, 12, 13, 14</param>
        /// <param name="rank">2, 3, 4...10, J, Q, K, A</param>
        public Card(string suit, int value, string rank)
        {
            this.suit = suit;
            this.value = value;
            this.rank = rank;
        }


        public override string? ToString()
        {
            return $"{rank}{suit}";
        }
    }
}
