namespace Excuse_Manager
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private bool formChanged = false;
        private string selectedFolder = "";

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsedTime.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
            openButton.Enabled = false;
            randomButton.Enabled = false;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                saveButton.Enabled = true;
                openButton.Enabled = true;
                randomButton.Enabled = true;
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (formChanged)
            {
                if (MessageBox.Show("The current excuse has not been saved.Continue?",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.No)
                    return;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentExcuse = new Excuse(openFileDialog1.FileName);
                UpdateForm(false);
                fileDateLabel.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
            }
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                excuseBox.Text = currentExcuse.Description;
                resultBox.Text = currentExcuse.Results;
                lastUsedTime.Value = currentExcuse.LastUsed;
                if (!string.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    fileDateLabel.Text = File.GetLastWriteTime
                        (currentExcuse.ExcusePath).ToString();
                    this.Text = "Excuse Manager";
                }
            }
            else
                this.Text = "Excuse Manager*";
            formChanged = changed;
        }

        private void FormTextChanged(object sender, EventArgs e)
        {
            currentExcuse.ExcusePath = saveFileDialog1.FileName;
            currentExcuse.Description = excuseBox.Text;
            currentExcuse.Results = resultBox.Text;
            UpdateForm(true);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = currentExcuse.ExcusePath;
            saveFileDialog1.InitialDirectory = selectedFolder;
            if (string.IsNullOrEmpty(excuseBox.Text)
                || string.IsNullOrEmpty(resultBox.Text))
            {
                MessageBox.Show("Please specify an excuse and a result",
                    "Unable to save",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentExcuse.SaveFile(saveFileDialog1.FileName);
                UpdateForm(false);
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            if (formChanged &&
                MessageBox.Show("The current excuse has not been saved.Continue?",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.No)
                return;
            currentExcuse = new(new Random(), selectedFolder);
            UpdateForm(false);
        }
    }
}