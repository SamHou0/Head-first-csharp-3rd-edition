using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_the_bee_2._0
{
    class Bee
    {
        public const double HoneyUnitsConsumedPerMg = .25;
        public double WeightMg { get; private set; }
        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }
        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}
