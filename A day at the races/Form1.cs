using System;
using System.Windows.Forms;

namespace A_day_at_the_races
{
    public partial class Form1 : Form
    {
        private Greyhound[] greyhounds;
        private Guy[] guys;
        private Random Myrandomizer = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            greyhounds = new Greyhound[4];
            guys = new Guy[3];
            greyhounds[0] = new Greyhound()
            {
                MyPictureBox = dog1,
                RacetrackLength = pictureBox1.Width - dog1.Width,
                StartingPosition = dog1.Left,
                Randommizer = Myrandomizer
            };
            greyhounds[1] = new Greyhound()
            {
                MyPictureBox = dog2,
                RacetrackLength = pictureBox1.Width - dog2.Width,
                StartingPosition = dog2.Left,
                Randommizer = Myrandomizer
            };
            greyhounds[2] = new Greyhound()
            {
                MyPictureBox = dog3,
                RacetrackLength = pictureBox1.Width - dog3.Width,
                StartingPosition = dog3.Left,
                Randommizer = Myrandomizer
            };
            greyhounds[3] = new Greyhound()
            {
                MyPictureBox = dog4,
                RacetrackLength = pictureBox1.Width - dog4.Width,
                StartingPosition = dog4.Left,
                Randommizer = Myrandomizer
            };
            guys[0] = new Guy()
            {
                Name = "joe",
                MyLable = joeBetLable,
                MyRadioButton = joeRadioButton,
                Cash = 100
            };
            guys[1] = new Guy()
            {
                Name = "bob",
                MyLable = bobBetLable,
                MyRadioButton = bobRadioButton,
                Cash = 100
            };
            guys[2] = new Guy()
            {
                Name = "al",
                MyLable = alBetLable,
                MyRadioButton = alRadioButton,
                Cash = 100
            };
            for (int i = 0; i < guys.Length; i++)
            {
                guys[i].ClearBet();
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                guys[0].UpdateLables();
                nameLable.Text = guys[0].Name;
            }
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bobRadioButton.Checked)
            {
                guys[1].UpdateLables();
                nameLable.Text = guys[1].Name;
            }
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (alRadioButton.Checked)
            {
                guys[2].UpdateLables();
                nameLable.Text = guys[2].Name;
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            bool status = false;
            if (joeRadioButton.Checked)
            {
                status = guys[0].PlaceBet((int)betAmount.Value, (int)dogNumber.Value);
            }
            else if (bobRadioButton.Checked)
            {
                status = guys[1].PlaceBet((int)betAmount.Value, (int)dogNumber.Value);
            }
            else if (alRadioButton.Checked)
            {
                status = guys[2].PlaceBet((int)betAmount.Value, (int)dogNumber.Value);
            }
            if (!status)
            {
                MessageBox.Show("Place bet failed.You don't have enough money.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            raceTimer.Start();
            bettingParlor.Enabled = false;
        }

        private void raceTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < greyhounds.Length; i++)
            {
                if (greyhounds[i].Run())
                {
                    raceTimer.Stop();
                    MessageBox.Show("The winner is dog" + (i + 1) + "!");
                    bettingParlor.Enabled = true;
                    foreach (Guy guy in guys)
                    {
                        guy.Collect(i + 1);
                    }
                    foreach (Greyhound greyhound in greyhounds)
                    {
                        greyhound.TakeStartingPosition();
                    }
                }
            }
        }
    }
}