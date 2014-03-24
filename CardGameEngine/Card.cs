using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameEngine
{
    public abstract class Card
    {
        public abstract override string ToString();
    }

    public class BicycleCard : Card
    {
        public char Value;
        public Suit Suit;
        public BicycleCard(char Value, Suit Suit) { this.Value = Value; this.Suit = Suit; }
        public override string ToString()
        {
            return this.Value + " " + this.Suit;
        }
    }

    public enum Suit { Hearts, Spades, Clubs, Diamonds };

}
