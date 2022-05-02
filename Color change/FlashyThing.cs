using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Color_change
{
    public partial class FlashyThing : Form
    {
        public FlashyThing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int c = 0; c < 253&&Visible; c++)
                {
                    BackColor = Color.FromArgb(c, 255 - c, c);

                    Application.DoEvents();
                    Thread.Sleep(3);
                }
                for (int c = 254; c > 0&&Visible; c--)
                {
                    BackColor = Color.FromArgb(c, 255 - c, c);

                    Application.DoEvents();
                    Thread.Sleep(3);
                }
            }
        }
    }
}
