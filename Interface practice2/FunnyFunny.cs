using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_practice2
{
    class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        protected string funnyThingIHave;
        public string FunnyThingIHave
        {
            get { return "Hi kids! I have a " + funnyThingIHave; }
        }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
