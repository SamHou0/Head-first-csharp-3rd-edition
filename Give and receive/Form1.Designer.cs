namespace Give_and_receive
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.joesCashLable = new System.Windows.Forms.Label();
            this.bobsCashLable = new System.Windows.Forms.Label();
            this.bankCashLable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joesCashLable
            // 
            this.joesCashLable.AutoSize = true;
            this.joesCashLable.Location = new System.Drawing.Point(139, 78);
            this.joesCashLable.Name = "joesCashLable";
            this.joesCashLable.Size = new System.Drawing.Size(95, 15);
            this.joesCashLable.TabIndex = 0;
            this.joesCashLable.Text = "Joe has $50";
            // 
            // bobsCashLable
            // 
            this.bobsCashLable.AutoSize = true;
            this.bobsCashLable.Location = new System.Drawing.Point(139, 371);
            this.bobsCashLable.Name = "bobsCashLable";
            this.bobsCashLable.Size = new System.Drawing.Size(103, 15);
            this.bobsCashLable.TabIndex = 1;
            this.bobsCashLable.Text = "Bob has $100";
            // 
            // bankCashLable
            // 
            this.bankCashLable.AutoSize = true;
            this.bankCashLable.Location = new System.Drawing.Point(139, 216);
            this.bankCashLable.Name = "bankCashLable";
            this.bankCashLable.Size = new System.Drawing.Size(143, 15);
            this.bankCashLable.TabIndex = 2;
            this.bankCashLable.Text = "The bank has $100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 183);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 187);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(531, 21);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(191, 183);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe gives $10 to Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(530, 216);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(191, 187);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashLable);
            this.Controls.Add(this.bobsCashLable);
            this.Controls.Add(this.joesCashLable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joesCashLable;
        private System.Windows.Forms.Label bobsCashLable;
        private System.Windows.Forms.Label bankCashLable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

