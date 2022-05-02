﻿namespace A_house
{
    partial class House
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
            this.description = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.exitBox = new System.Windows.Forms.ComboBox();
            this.goThroughDoorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 12);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(430, 213);
            this.description.TabIndex = 0;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(12, 231);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(94, 47);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go here:";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // exitBox
            // 
            this.exitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exitBox.FormattingEnabled = true;
            this.exitBox.Location = new System.Drawing.Point(149, 241);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(274, 28);
            this.exitBox.TabIndex = 2;
            // 
            // goThroughDoorButton
            // 
            this.goThroughDoorButton.Location = new System.Drawing.Point(12, 284);
            this.goThroughDoorButton.Name = "goThroughDoorButton";
            this.goThroughDoorButton.Size = new System.Drawing.Size(411, 38);
            this.goThroughDoorButton.TabIndex = 3;
            this.goThroughDoorButton.Text = "Go through the door";
            this.goThroughDoorButton.UseVisualStyleBackColor = true;
            this.goThroughDoorButton.Click += new System.EventHandler(this.goThroughDoorButton_Click);
            // 
            // House
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 334);
            this.Controls.Add(this.goThroughDoorButton);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.description);
            this.Name = "House";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ComboBox exitBox;
        private System.Windows.Forms.Button goThroughDoorButton;
    }
}