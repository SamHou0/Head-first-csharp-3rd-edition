namespace Dictionary_Practice
{
    public partial class Form1 : Form
    {
        Dictionary<int, JerseyNumber> retiredNumbers =
            new()
            {
                {3,new JerseyNumber("Babe Ruth",1948) },
                {4,new JerseyNumber("Lou Gehrig",1939) },
                {5,new JerseyNumber("Joe Dimaggio",1952) },
                {7,new JerseyNumber("Mickey Mantle",1969) },
                {8,new JerseyNumber("Yogi Berra",1972) },
                {10,new JerseyNumber("Phil Rizzuto",1985) },
                {23,new JerseyNumber("Don Mattingly",1997) },
                {42,new JerseyNumber("Jackie Robinson",1993) },
                {44,new JerseyNumber("Reggie Jackson",1993) },
            };
        public Form1()
        {
            InitializeComponent();
            foreach (int key in retiredNumbers.Keys)
            {
                numberBox.Items.Add(key);
            }
        }

        private void NumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            JerseyNumber jerseyNumber = retiredNumbers[(int)numberBox.SelectedItem];
            nameLabel.Text = jerseyNumber.Player;
            yearLabel.Text=jerseyNumber.YearRetired.ToString();
        }
    }
}