using System.Windows.Forms;

namespace A_day_at_the_races
{
    public class Guy
    {
        public string Name;
        public Bet MyBet = new Bet();
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLable;

        public void UpdateLables()
        {
            MyLable.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Cash + " bucks.";
        }

        public void ClearBet()
        {
            MyBet = new Bet() { Bettor = this };
            UpdateLables();
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            if (Cash >= BetAmount)
            {
                MyBet = new Bet() { Bettor = this, Amount = BetAmount, Dog = DogToWin };
                UpdateLables();
                return true;
            }
            else
            {
                UpdateLables();
                return false;
            }
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLables();
        }
    }
}