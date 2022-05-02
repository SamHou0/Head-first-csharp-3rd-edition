namespace Excuse_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.excuseBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.lastUsedTime = new System.Windows.Forms.DateTimePicker();
            this.fileDateLabel = new System.Windows.Forms.Label();
            this.folderButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excuse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Used";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "File date";
            // 
            // excuseBox
            // 
            this.excuseBox.Location = new System.Drawing.Point(144, 20);
            this.excuseBox.Name = "excuseBox";
            this.excuseBox.Size = new System.Drawing.Size(277, 27);
            this.excuseBox.TabIndex = 4;
            this.excuseBox.TextChanged += new System.EventHandler(this.FormTextChanged);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(144, 52);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(277, 27);
            this.resultBox.TabIndex = 5;
            this.resultBox.TextChanged += new System.EventHandler(this.FormTextChanged);
            // 
            // lastUsedTime
            // 
            this.lastUsedTime.Location = new System.Drawing.Point(148, 95);
            this.lastUsedTime.Name = "lastUsedTime";
            this.lastUsedTime.Size = new System.Drawing.Size(273, 27);
            this.lastUsedTime.TabIndex = 6;
            this.lastUsedTime.ValueChanged += new System.EventHandler(this.FormTextChanged);
            // 
            // fileDateLabel
            // 
            this.fileDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileDateLabel.Location = new System.Drawing.Point(144, 135);
            this.fileDateLabel.Name = "fileDateLabel";
            this.fileDateLabel.Size = new System.Drawing.Size(277, 26);
            this.fileDateLabel.TabIndex = 7;
            this.fileDateLabel.Text = "time";
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(12, 181);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(94, 29);
            this.folderButton.TabIndex = 8;
            this.folderButton.Text = "Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(112, 181);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(212, 181);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(94, 29);
            this.openButton.TabIndex = 10;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(312, 181);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(109, 29);
            this.randomButton.TabIndex = 11;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text Files|*.txt";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose a folder";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 232);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.fileDateLabel);
            this.Controls.Add(this.lastUsedTime);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.excuseBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox excuseBox;
        private TextBox resultBox;
        private DateTimePicker lastUsedTime;
        private Label fileDateLabel;
        private Button folderButton;
        private Button saveButton;
        private Button openButton;
        private Button randomButton;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}