using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_practice
{
    class Bee:IStingPatrol
    {
        public bool LookForEnemies()
        {
            return true;
        }
       public int SharpenStinger(int a)
        {
            return a;
        }
        public int AlertLevel { get; set; }
        public int StingerLength { get; set; }
    }
}
