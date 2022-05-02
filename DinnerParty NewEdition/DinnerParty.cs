using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty_NewEdition
{
    internal class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
            {
                return NumberOfPeople * 15M + 50M;
            }
            else
            {
                return NumberOfPeople * 7.5M + 30M;
            }
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
            {
                return 5M;
            }
            else
            {
                return 20M;
            }
        }

        public decimal Cost
        {
            get
            {
                if (HealthyOption)
                {
                    return (CalculateCostOfDecorations() + CalculateCostOfBeveragesPerPerson() * NumberOfPeople) * 0.95M;
                }
                else
                {
                    return CalculateCostOfDecorations() + CalculateCostOfBeveragesPerPerson() * NumberOfPeople;
                }
            }
        }
    }
}