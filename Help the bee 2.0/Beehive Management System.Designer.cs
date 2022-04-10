
namespace Help_the_bee_2._0
{
    partial class Beehive_Management_System
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assignButton = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.jobs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.workButton = new System.Windows.Forms.Button();
            this.reportBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignButton);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.jobs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(22, 71);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(351, 32);
            this.assignButton.TabIndex = 4;
            this.assignButton.Text = "Assign this job to a bee";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(253, 40);
            this.shifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(120, 25);
            this.shifts.TabIndex = 3;
            this.shifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shifts";
            // 
            // jobs
            // 
            this.jobs.FormattingEnabled = true;
            this.jobs.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.jobs.Location = new System.Drawing.Point(10, 43);
            this.jobs.Name = "jobs";
            this.jobs.Size = new System.Drawing.Size(233, 23);
            this.jobs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job";
            // 
            // workButton
            // 
            this.workButton.Font = new System.Drawing.Font("宋体", 20F);
            this.workButton.Location = new System.Drawing.Point(473, 13);
            this.workButton.Name = "workButton";
            this.workButton.Size = new System.Drawing.Size(302, 119);
            this.workButton.TabIndex = 1;
            this.workButton.Text = "Work the next shift";
            this.workButton.UseVisualStyleBackColor = true;
            this.workButton.Click += new System.EventHandler(this.workButton_Click);
            // 
            // reportBox
            // 
            this.reportBox.Location = new System.Drawing.Point(23, 138);
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(752, 300);
            this.reportBox.TabIndex = 2;
            this.reportBox.Text = "";
            // 
            // Beehive_Management_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportBox);
            this.Controls.Add(this.workButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Beehive_Management_System";
            this.Text = "Beehive_Management_System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox jobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button workButton;
        private System.Windows.Forms.RichTextBox reportBox;
    }
}