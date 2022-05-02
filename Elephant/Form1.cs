using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    public partial class Form1 : Form
    {
        private Elephant lucinda = new Elephant() { Name = "lucinda", EarSize = 33 };
        private Elephant lloyd = new Elephant() { Name = "lloyd", EarSize = 40 };

        public Form1()
        {
            InitializeComponent();
        }

        private void lloyd_button_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void lucinda_button_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void swap_button_Click(object sender, EventArgs e)
        {
            Elephant a = lucinda;
            lucinda = lloyd;
            lloyd = a;
            MessageBox.Show("Objects swapped!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd.SpeakTo(lucinda, "Hello");
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}