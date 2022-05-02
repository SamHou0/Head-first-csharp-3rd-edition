using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    internal class Deck
    {
        private List<Card> cards;
        private Random random=new Random();
        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suits)suit,(Values)value));
        }
        public Deck(IEnumerable<Card> initialCards)
        {
            cards=new List<Card>(initialCards);
        }
        public int Count { get { return cards.Count; } }
        public void Add(Card card)
        {
            cards.Add(card);
        }
        public Card Deal(int index)
        {
            Card cardToDeal=cards[index];
            cards.RemoveAt(index);
            return cardToDeal;
        }
        public void Shuffle()
        {
            List<Card> newCards = new List<Card>();
            while (cards.Count > 0)
            {
                int removeIndex = random.Next(cards.Count);
                newCards.Add(cards[removeIndex]);
                cards.RemoveAt(removeIndex);
            }
            cards = newCards;
        }
        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }
        public IEnumerable<string> GetCardNames()
        {
            List<string > names = new List<string>();
            foreach (Card card in cards)
            {
                names.Add(card.ToString());
            }
            return names;
        }
    }
}
