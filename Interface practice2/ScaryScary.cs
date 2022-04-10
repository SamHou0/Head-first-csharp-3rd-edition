using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_practice2
{
    class ScaryScary : FunnyFunny,IScaryClown
    {
        public string ScaryThingIHave
        {
            get { return "I have "+numberOfScaryThings + " spiders"; }
        }
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings):base (funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        private int numberOfScaryThings;

        public void ScareLittleChildren()
        {
            MessageBox.Show("You can't have my " + base.funnyThingIHave);
        }
    }
}
