namespace Dictionary_Practice
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
            this.numberBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberBox
            // 
            this.numberBox.FormattingEnabled = true;
            this.numberBox.Location = new System.Drawing.Point(102, 28);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(112, 28);
            this.numberBox.TabIndex = 0;
            this.numberBox.SelectedIndexChanged += new System.EventHandler(this.NumberBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(334, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "name";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(586, 31);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(42, 20);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "was worn by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "are retired in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 104);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.numberBox);
            this.Name = "Form1";
            this.Text = "Retired Jersey Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox numberBox;
        private Label nameLabel;
        private Label yearLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}