using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MenuMaker menuMaker = new MenuMaker();

            label1.Text = menuMaker.GetMenuItem();
            label2.Text = menuMaker.GetMenuItem();
            label3.Text = menuMaker.GetMenuItem();
            label4.Text = menuMaker.GetMenuItem();
            label5.Text = menuMaker.GetMenuItem();
            label6.Text = menuMaker.GetMenuItem();
        }
    }
}