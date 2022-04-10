using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deck
{
    public partial class DeckForm : Form
    {
        private Deck deck1;
        private Deck deck2;
        private Random random = new Random();

        public DeckForm()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }
        private void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                int numberOfDeck = random.Next(1, 11);
                deck1 = new Deck(new List<Card> { });
                for (int i = 0; i < numberOfDeck; i++)
                {
                    deck1.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 11)));
                }
            }
            else
                deck2 = new();
        }
        private void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                deckList1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                {
                    deckList1.Items.Add(cardName);
                }
                label1.Text = "Deck #1 (" + deck1.Count + " cards)";
            }
            else
            {
                deckList2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                {
                    deckList2.Items.Add(cardName);
                }
                label2.Text = "Deck #1 (" + deck2.Count + " cards)";
            }
        }

        private void resetButton1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void shuffleButton1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void resetButton2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffleButton2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void moveToDeck2Button_Click(object sender, EventArgs e)
        {
            if (deckList1.SelectedIndex >= 0)
                if (deck1.Count > 0)
                    deck2.Add(deck1.Deal(deckList1.SelectedIndex));
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveToDeck1Button_Click(object sender, EventArgs e)
        {
            if (deckList2.SelectedIndex >= 0)
                if (deck2.Count > 0)
                    deck1.Add(deck2.Deal(deckList2.SelectedIndex));
            RedrawDeck(1);
            RedrawDeck(2);
        }
    }
}
