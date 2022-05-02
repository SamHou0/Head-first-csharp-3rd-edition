namespace Type_game
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctlable = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.accuracyLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatueLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("楷体", 60F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 100;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(854, 123);
            this.listBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctlable,
            this.missedLable,
            this.totalLable,
            this.accuracyLable,
            this.StatueLable,
            this.difficultyProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 97);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // correctlable
            // 
            this.correctlable.Name = "correctlable";
            this.correctlable.Size = new System.Drawing.Size(77, 20);
            this.correctlable.Text = "Correct:0";
            // 
            // missedLable
            // 
            this.missedLable.Name = "missedLable";
            this.missedLable.Size = new System.Drawing.Size(74, 20);
            this.missedLable.Text = "Missed:0";
            // 
            // totalLable
            // 
            this.totalLable.Name = "totalLable";
            this.totalLable.Size = new System.Drawing.Size(59, 20);
            this.totalLable.Text = "Total:0";
            // 
            // accuracyLable
            // 
            this.accuracyLable.Name = "accuracyLable";
            this.accuracyLable.Size = new System.Drawing.Size(101, 20);
            this.accuracyLable.Text = "Accuracy:0%";
            // 
            // StatueLable
            // 
            this.StatueLable.Name = "StatueLable";
            this.StatueLable.Size = new System.Drawing.Size(426, 20);
            this.StatueLable.Spring = true;
            this.StatueLable.Text = "Difficulty";
            this.StatueLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultyProgressBar
            // 
            this.difficultyProgressBar.Maximum = 701;
            this.difficultyProgressBar.Name = "difficultyProgressBar";
            this.difficultyProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 123);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hit the keys!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel correctlable;
        private System.Windows.Forms.ToolStripStatusLabel missedLable;
        private System.Windows.Forms.ToolStripStatusLabel totalLable;
        private System.Windows.Forms.ToolStripStatusLabel accuracyLable;
        private System.Windows.Forms.ToolStripStatusLabel StatueLable;
        private System.Windows.Forms.ToolStripProgressBar difficultyProgressBar;
    }
}

