namespace Deck
{
    partial class DeckForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deckList1 = new System.Windows.Forms.ListBox();
            this.deckList2 = new System.Windows.Forms.ListBox();
            this.moveToDeck2Button = new System.Windows.Forms.Button();
            this.moveToDeck1Button = new System.Windows.Forms.Button();
            this.resetButton1 = new System.Windows.Forms.Button();
            this.resetButton2 = new System.Windows.Forms.Button();
            this.shuffleButton1 = new System.Windows.Forms.Button();
            this.shuffleButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deck #1 (0 cards)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deck #2 (52 cards)";
            // 
            // deckList1
            // 
            this.deckList1.FormattingEnabled = true;
            this.deckList1.ItemHeight = 20;
            this.deckList1.Location = new System.Drawing.Point(25, 63);
            this.deckList1.Name = "deckList1";
            this.deckList1.Size = new System.Drawing.Size(135, 264);
            this.deckList1.TabIndex = 2;
            // 
            // deckList2
            // 
            this.deckList2.FormattingEnabled = true;
            this.deckList2.ItemHeight = 20;
            this.deckList2.Location = new System.Drawing.Point(292, 63);
            this.deckList2.Name = "deckList2";
            this.deckList2.Size = new System.Drawing.Size(143, 264);
            this.deckList2.TabIndex = 3;
            // 
            // moveToDeck2Button
            // 
            this.moveToDeck2Button.Location = new System.Drawing.Point(178, 118);
            this.moveToDeck2Button.Name = "moveToDeck2Button";
            this.moveToDeck2Button.Size = new System.Drawing.Size(94, 29);
            this.moveToDeck2Button.TabIndex = 4;
            this.moveToDeck2Button.Text = ">>";
            this.moveToDeck2Button.UseVisualStyleBackColor = true;
            this.moveToDeck2Button.Click += new System.EventHandler(this.moveToDeck2Button_Click);
            // 
            // moveToDeck1Button
            // 
            this.moveToDeck1Button.Location = new System.Drawing.Point(178, 238);
            this.moveToDeck1Button.Name = "moveToDeck1Button";
            this.moveToDeck1Button.Size = new System.Drawing.Size(94, 29);
            this.moveToDeck1Button.TabIndex = 5;
            this.moveToDeck1Button.Text = "<<";
            this.moveToDeck1Button.UseVisualStyleBackColor = true;
            this.moveToDeck1Button.Click += new System.EventHandler(this.moveToDeck1Button_Click);
            // 
            // resetButton1
            // 
            this.resetButton1.Location = new System.Drawing.Point(26, 333);
            this.resetButton1.Name = "resetButton1";
            this.resetButton1.Size = new System.Drawing.Size(134, 36);
            this.resetButton1.TabIndex = 6;
            this.resetButton1.Text = "Reset Deck #1";
            this.resetButton1.UseVisualStyleBackColor = true;
            this.resetButton1.Click += new System.EventHandler(this.resetButton1_Click);
            // 
            // resetButton2
            // 
            this.resetButton2.Location = new System.Drawing.Point(292, 333);
            this.resetButton2.Name = "resetButton2";
            this.resetButton2.Size = new System.Drawing.Size(143, 36);
            this.resetButton2.TabIndex = 7;
            this.resetButton2.Text = "Reset Deck #2";
            this.resetButton2.UseVisualStyleBackColor = true;
            this.resetButton2.Click += new System.EventHandler(this.resetButton2_Click);
            // 
            // shuffleButton1
            // 
            this.shuffleButton1.Location = new System.Drawing.Point(26, 375);
            this.shuffleButton1.Name = "shuffleButton1";
            this.shuffleButton1.Size = new System.Drawing.Size(134, 34);
            this.shuffleButton1.TabIndex = 8;
            this.shuffleButton1.Text = "Shuffle Deck #1";
            this.shuffleButton1.UseVisualStyleBackColor = true;
            this.shuffleButton1.Click += new System.EventHandler(this.shuffleButton1_Click);
            // 
            // shuffleButton2
            // 
            this.shuffleButton2.Location = new System.Drawing.Point(292, 375);
            this.shuffleButton2.Name = "shuffleButton2";
            this.shuffleButton2.Size = new System.Drawing.Size(143, 34);
            this.shuffleButton2.TabIndex = 9;
            this.shuffleButton2.Text = "Shuffle Deck #2";
            this.shuffleButton2.UseVisualStyleBackColor = true;
            this.shuffleButton2.Click += new System.EventHandler(this.shuffleButton2_Click);
            // 
            // DeckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 433);
            this.Controls.Add(this.shuffleButton2);
            this.Controls.Add(this.shuffleButton1);
            this.Controls.Add(this.resetButton2);
            this.Controls.Add(this.resetButton1);
            this.Controls.Add(this.moveToDeck1Button);
            this.Controls.Add(this.moveToDeck2Button);
            this.Controls.Add(this.deckList2);
            this.Controls.Add(this.deckList1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeckForm";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox deckList1;
        private ListBox deckList2;
        private Button moveToDeck2Button;
        private Button moveToDeck1Button;
        private Button resetButton1;
        private Button resetButton2;
        private Button shuffleButton1;
        private Button shuffleButton2;
    }
}