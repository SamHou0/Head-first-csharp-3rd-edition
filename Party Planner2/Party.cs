using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner2
{
    public class Party
    {
        public virtual decimal Cost { get; set; }
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public decimal CalculateCostOfDecorations()
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
    }
}
