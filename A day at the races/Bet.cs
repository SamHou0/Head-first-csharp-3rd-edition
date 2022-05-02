namespace A_day_at_the_races
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            return Bettor.Name + " bets " + Amount + " on dog " + Dog;
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}