using System;

namespace Card // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new();
            Random random = new();
            for (int i = 0; i < 5; i++)
            {
                Suits suit = (Suits)random.Next(4);
                Values value = (Values)random.Next(1, 14);
                Card card = new(suit, value);
                cards.Add(card);
            }
            Console.WriteLine("Five random cards:");
            PrintCards(cards);

            CardComparer_byValue cardComparer = new();
            cards.Sort(cardComparer);

            Console.WriteLine("Those same cards, sorted:");
            PrintCards(cards);

            Console.ReadKey();
        }
        static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}