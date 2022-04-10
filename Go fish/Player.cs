using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_fish
{
    internal class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;
        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.cards = new Deck();
            this.textBoxOnForm = textBoxOnForm;
            textBoxOnForm.Text += name + " has just joined the game"+Environment.NewLine;
        }
        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value == value)
                        howMany++;
                }
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }
        public Values GetRandomValue()
        {
            int i = random.Next(cards.Count);
            return cards.Peek(i).Value;
        }
        public Deck DoYouHaveAny(Values value)
        {
            Deck deck = cards.PullOutValues(value);
            textBoxOnForm.Text += name + " has " + deck.Count+" " + Card.Plural(value)
                +Environment.NewLine;

            return deck;
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            if (stock.Count > 0)
            {
                if (cards.Count == 0)
                    cards.Add(stock.Deal());
                Values value = GetRandomValue();
                AskForACard(players, myIndex, stock, value);
            }
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += name + " ask if anyone has a " + value + Environment.NewLine;
            int count = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i == myIndex)
                    continue;
                Deck deck = players[i].DoYouHaveAny(value);
                count += deck.Count;
                while (deck.Count > 0)
                    cards.Add(deck.Deal());
            }
            if (count == 0 && stock.Count > 0)
            {
                cards.Add(stock.Deal());
                textBoxOnForm.Text += name + " had to draw from the stock"
                    + Environment.NewLine;
            }
        }
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int number) { return cards.Peek(number); }
        public void SortHand() { cards.SortByValue(); }
    }
}
