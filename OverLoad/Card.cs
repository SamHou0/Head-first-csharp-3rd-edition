using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad
{
    internal class Card
    {
        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }
        public Suits Suit { get; }
        public Values Value { get; }
        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }
        public override string ToString()
        {
            return Name;
        }
        public static bool DoesCardMatch(Card cardToCheck,Suits suit)
        {
            if (cardToCheck.Suit==suit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DoesCardMatch(Card cardToCheck,Values value)
        {
            if (cardToCheck.Value==value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
