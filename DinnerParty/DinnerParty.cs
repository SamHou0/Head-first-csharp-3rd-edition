using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    internal class DinnerParty
    {
        public int NumberOfPeople;
        private decimal CostOfBeveragesPerPerson;
        private decimal CostOfDecorations;

        public const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool healthyoption)
        {
            if (healthyoption)
            {
                CostOfBeveragesPerPerson = 5M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20M;
            }
        }

        public void CalculateCostOfDecorations(bool fancyoption)
        {
            if (fancyoption)
            {
                CostOfDecorations = NumberOfPeople * 15M + 50M;
            }
            else
            {
                CostOfDecorations = NumberOfPeople * 7.5M + 30M;
            }
        }

        public decimal CalculateCost(bool healthyoption)
        {
            decimal Cost = NumberOfPeople * CostOfFoodPerPerson + CostOfDecorations + CostOfBeveragesPerPerson * NumberOfPeople;
            if (healthyoption)
            {
                Cost *= 0.95M;
            }
            return Cost;
        }
    }
}