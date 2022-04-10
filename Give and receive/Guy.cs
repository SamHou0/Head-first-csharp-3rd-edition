using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Give_and_receive
{
    internal class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amout)
        {
            if (amout <= Cash && amout > 0)
            {
                Cash -= amout;
                return amout;
            }
            else
            {
                MessageBox.Show("I don't have enough cash to give you " + amout, Name + " Says...");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " isn't an amount I'll take", Name + " Says...");
                return 0;
            }
        }
    }
}