namespace Go_fish
{
    internal class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox texBoxOnForm;
        public Game(string playerName, IEnumerable<string> opponetNames,
            TextBox textBoxOnForm)
        {
            Random random = new();
            this.texBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in opponetNames)
                players.Add(new Player(player, random, textBoxOnForm));
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();
            foreach (Player player in players)
            {
                for (int i = 0; i < 5; i++)
                    player.TakeCard(stock.Deal());
                player.PullOutBooks();
            }
        }

        internal IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        internal string DescribeBooks()
        {
            string returnString = "";
            foreach (KeyValuePair<Values,Player> pair in books)
            {
                returnString += pair.Value.Name + " has a book of " + Card.Plural(pair.Key)
                    +Environment.NewLine;
            }
            return returnString;
        }

        internal string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }
            description += "The stock has " + stock.Count + " cards left.";
            return description;

        }

        internal bool PlayOneRound(int selectedIndex)
        {
            Values value = players[0].Peek(selectedIndex).Value;
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                {
                    players[i].AskForACard(players, i, stock, value);
                }
                else
                    players[i].AskForACard(players, i, stock);
                if (PullOutBooks(players[i]))
                {
                    for (int m = 0; m < 5; m++)
                    {
                        if (stock.Count == 0)
                            break;
                        players[i].TakeCard(stock.Deal());
                    }
                }
            }
            if (stock.Count == 0)
                return true;
            return false;

        }

        private bool PullOutBooks(Player player)
        {
            IEnumerable<Values> values = player.PullOutBooks();
            foreach (Values value in values)
            {
                books.Add(value, player);
            }
            if (player.CardCount == 0)
                return true;
            return false;
        }

        internal string GetWinnerName()
        {
            Dictionary<string,int> winners = new();
            foreach (Values value in books.Keys)
            {
                string name = books[value].Name;
                if (winners.ContainsKey(name))
                    winners[name]++;
                else
                    winners.Add(name, 1);
            }
            int maxValue = 0;
            foreach (int value in winners.Values)
            {
                if(value>maxValue)
                    maxValue = value;
            }
            List<string> playerNames = new();
            foreach (string palyerName in winners.Keys)
            {
                if(winners[palyerName]==maxValue)
                    playerNames.Add(palyerName);
            }
            if (playerNames.Count==1)
            {
                return playerNames[0] + " with " + maxValue + " books";
            }
            else
            {
                return "A tie between " + playerNames[0] + 
                    " and " + playerNames[1]+" with "+maxValue+" books.";
            }
        }
    }
}