﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Help_the_bee_2._0
{
    public partial class Beehive_Management_System : Form
    {
        Queen queen;
        public Beehive_Management_System()
        {
            InitializeComponent();
            jobs.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" },175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" },114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" },149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" },155);
            queen = new Queen(workers,275);
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            reportBox.Text += queen.WorkTheNextShift();
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(jobs.Text, Convert.ToInt32(shifts.Value)))
                MessageBox.Show($"The job {jobs.Text} will be finished in {shifts.Value} shifts!!!", "The queen bee says......");
            else
                MessageBox.Show($"No bees available to the job {jobs.Text}......", "The queen bee says......");
        }
    }
}
