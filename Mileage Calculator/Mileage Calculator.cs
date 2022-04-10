using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mileage_Calculator
{
    public partial class Mileage_Calculator : Form
    {
        private int startingMileage;
        private int endingMileage;
        private double milesTraveled;
        private double reimburseRate = .39;
        private double amountOwned;

        public Mileage_Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwned = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwned;
            }
            else
            {
                MessageBox.Show("The starting message must be less than the ending message", "Cannot calculate mileage");
            }
        }
    }
}