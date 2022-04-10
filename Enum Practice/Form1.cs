namespace Enum_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random=new();
           Suits suit=(Suits) random.Next(4);
           Values value=(Values) random.Next(1, 14);
            Card card=new(suit,value);
            MessageBox.Show(card.Name);
        }
    }
}