using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card
    {
        //card data
        string rank;
        string suit;
        int val;

        public Card(string rank, string suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public Card(string rank, string suit, int val)
        {
            this.Rank = rank;
            this.Suit = suit;
            this.Val = val;
        }

        public int Value
        {
            get
            {
                return Val;
            }
            set
            {
                Val = value;
            }

        }

        public string Rank { get => rank; set => rank = value; }
        public string Suit { get => suit; set => suit = value; }
        public int Val { get => val; set => val = value; }

        public override string ToString()
        {
            return Rank + " " + Suit;
        }
    }
}
