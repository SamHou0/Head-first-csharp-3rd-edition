using System.IO;
namespace Simple_Text_Editor
{
    public partial class Form1 : Form
    {
        string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                name=saveFileDialog1.FileName;
                File.WriteAllText(name,textBox1.Text);
            }
        }
    }
}