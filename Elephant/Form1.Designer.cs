namespace Elephant
{
    partial class Form1
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
            this.lloyd_button = new System.Windows.Forms.Button();
            this.lucinda_button = new System.Windows.Forms.Button();
            this.swap_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lloyd_button
            // 
            this.lloyd_button.Location = new System.Drawing.Point(234, 50);
            this.lloyd_button.Name = "lloyd_button";
            this.lloyd_button.Size = new System.Drawing.Size(302, 132);
            this.lloyd_button.TabIndex = 0;
            this.lloyd_button.Text = "Lloyd";
            this.lloyd_button.UseVisualStyleBackColor = true;
            this.lloyd_button.Click += new System.EventHandler(this.lloyd_button_Click);
            // 
            // lucinda_button
            // 
            this.lucinda_button.Location = new System.Drawing.Point(234, 212);
            this.lucinda_button.Name = "lucinda_button";
            this.lucinda_button.Size = new System.Drawing.Size(302, 120);
            this.lucinda_button.TabIndex = 1;
            this.lucinda_button.Text = "Lucinda";
            this.lucinda_button.UseVisualStyleBackColor = true;
            this.lucinda_button.Click += new System.EventHandler(this.lucinda_button_Click);
            // 
            // swap_button
            // 
            this.swap_button.Location = new System.Drawing.Point(234, 354);
            this.swap_button.Name = "swap_button";
            this.swap_button.Size = new System.Drawing.Size(302, 84);
            this.swap_button.TabIndex = 2;
            this.swap_button.Text = "Swap!";
            this.swap_button.UseVisualStyleBackColor = true;
            this.swap_button.Click += new System.EventHandler(this.swap_button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 350);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.swap_button);
            this.Controls.Add(this.lucinda_button);
            this.Controls.Add(this.lloyd_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lloyd_button;
        private System.Windows.Forms.Button lucinda_button;
        private System.Windows.Forms.Button swap_button;
        private System.Windows.Forms.Button button4;
    }
}