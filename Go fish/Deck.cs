using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_fish
{
    internal class Deck
    {
        private List<Card> cards;
        private Random random = new();
        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }
        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }
        public int Count { get { return cards.Count; } }
        public void Add(Card card)
        {
            cards.Add(card);
        }
        public Card Deal(int index)
        {
            Card cardToDeal = cards[index];
            cards.RemoveAt(index);
            return cardToDeal;
        }
        public void Shuffle()
        {
            List<Card> newCards = new();
            while (cards.Count > 0)
            {
                int removeIndex = random.Next(cards.Count);
                newCards.Add(cards[removeIndex]);
                cards.RemoveAt(removeIndex);
            }
            cards = newCards;
        }
        public IEnumerable<string> GetCardNames()
        {
            List<string> names = new();
            foreach (Card card in cards)
            {
                names.Add(card.ToString());
            }
            return names;
        }
        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }
        public Card Deal()
        {
            return Deal(0);
        }
        public bool ContainsValue(Values value)
        {
            foreach (Card card in cards)
            {
                if (card.Value==value)
                    return true;
            }
            return false;
        }
        public Deck PullOutValues(Values value)
        {
            Deck deckToRetrun = new(new Card[] {});
            for (int i = cards.Count-1; i >= 0; i--)
            {
                if(cards[i].Value==value)
                    deckToRetrun.Add(Deal(i));
            }
            return deckToRetrun;
        }
        public bool HasBook(Values value)
        {
            int NumberOfCards = 0;
            foreach (Card card in cards)
            {
                if(card.Value==value)
                    NumberOfCards++;
            }
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }
        public void SortByValue()
        {
            cards.Sort(new CardComparer_byValue());
        }
    }
}
