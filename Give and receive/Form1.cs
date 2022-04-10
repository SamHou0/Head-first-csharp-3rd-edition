using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Give_and_receive
{
    public partial class Form1 : Form
    {
        private Guy joe;
        private Guy bob;
        private int bank = 100;

        public void UpdateForm()
        {
            joesCashLable.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLable.Text = bob.Name + " has $ " + bob.Cash;
            bankCashLable.Text = "The bank has $ " + bank;
        }

        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { Cash = 50, Name = "joe" };
            bob = new Guy() { Cash = 100, Name = "bob" };

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }
    }
}