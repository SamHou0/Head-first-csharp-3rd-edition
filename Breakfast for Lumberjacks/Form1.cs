using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakfast_for_Lumberjacks
{
    public partial class Form1 : Form
    {
        
        Queue<Lumberjack> queue;
        public Form1()
        {
            InitializeComponent();
            queue = new Queue<Lumberjack>();
            RedrawList();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if (queue.Count == 0)
            {
                nextInLine.Text = "";
                return;
            }
            Flapjack food;
            if (crispy.Checked)
                food = Flapjack.Crispy;
            else if (soggy.Checked)
                food = Flapjack.Soggy;
            else if (browned.Checked)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;
            Lumberjack lumberjack = queue.Peek();
            lumberjack.TakeFlapjacks(food, (int)howMany.Value);
            nextInLine.Text = lumberjack.Name + " has " + lumberjack.FlapjackCount + " flapjacks.";
            RedrawList();
        }

        private void RedrawList()
        {
            line.Items.Clear();
            int number = 1;
            foreach (Lumberjack lumberjack in queue)
            {
                line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (queue.Count == 0)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled=true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            queue.Enqueue(new Lumberjack(textBox1.Text));
            RedrawList();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Lumberjack lumberjack = queue.Dequeue();
            lumberjack.EatFlapjacks();
            RedrawList();
        }
    }
}
