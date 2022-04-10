using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner2
{
    public class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
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

        public override decimal Cost
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