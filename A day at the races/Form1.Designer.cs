namespace A_day_at_the_races
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.bettingParlor = new System.Windows.Forms.GroupBox();
            this.betButton = new System.Windows.Forms.Button();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.raceButton = new System.Windows.Forms.Button();
            this.alBetLable = new System.Windows.Forms.Label();
            this.bobBetLable = new System.Windows.Forms.Label();
            this.joeBetLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLable = new System.Windows.Forms.Label();
            this.minimumBetLable = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.bettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // dog1
            // 
            resources.ApplyResources(this.dog1, "dog1");
            this.dog1.Name = "dog1";
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            resources.ApplyResources(this.dog2, "dog2");
            this.dog2.Name = "dog2";
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            resources.ApplyResources(this.dog3, "dog3");
            this.dog3.Name = "dog3";
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            resources.ApplyResources(this.dog4, "dog4");
            this.dog4.Name = "dog4";
            this.dog4.TabStop = false;
            // 
            // bettingParlor
            // 
            this.bettingParlor.Controls.Add(this.betButton);
            this.bettingParlor.Controls.Add(this.dogNumber);
            this.bettingParlor.Controls.Add(this.betAmount);
            this.bettingParlor.Controls.Add(this.raceButton);
            this.bettingParlor.Controls.Add(this.alBetLable);
            this.bettingParlor.Controls.Add(this.bobBetLable);
            this.bettingParlor.Controls.Add(this.joeBetLable);
            this.bettingParlor.Controls.Add(this.label3);
            this.bettingParlor.Controls.Add(this.label2);
            this.bettingParlor.Controls.Add(this.nameLable);
            this.bettingParlor.Controls.Add(this.minimumBetLable);
            this.bettingParlor.Controls.Add(this.alRadioButton);
            this.bettingParlor.Controls.Add(this.bobRadioButton);
            this.bettingParlor.Controls.Add(this.joeRadioButton);
            resources.ApplyResources(this.bettingParlor, "bettingParlor");
            this.bettingParlor.Name = "bettingParlor";
            this.bettingParlor.TabStop = false;
            // 
            // betButton
            // 
            resources.ApplyResources(this.betButton, "betButton");
            this.betButton.Name = "betButton";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // dogNumber
            // 
            resources.ApplyResources(this.dogNumber, "dogNumber");
            this.dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betAmount
            // 
            resources.ApplyResources(this.betAmount, "betAmount");
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // raceButton
            // 
            resources.ApplyResources(this.raceButton, "raceButton");
            this.raceButton.Name = "raceButton";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // alBetLable
            // 
            this.alBetLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.alBetLable, "alBetLable");
            this.alBetLable.Name = "alBetLable";
            // 
            // bobBetLable
            // 
            this.bobBetLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.bobBetLable, "bobBetLable");
            this.bobBetLable.Name = "bobBetLable";
            // 
            // joeBetLable
            // 
            this.joeBetLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.joeBetLable, "joeBetLable");
            this.joeBetLable.Name = "joeBetLable";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // nameLable
            // 
            resources.ApplyResources(this.nameLable, "nameLable");
            this.nameLable.Name = "nameLable";
            // 
            // minimumBetLable
            // 
            resources.ApplyResources(this.minimumBetLable, "minimumBetLable");
            this.minimumBetLable.Name = "minimumBetLable";
            // 
            // alRadioButton
            // 
            resources.ApplyResources(this.alRadioButton, "alRadioButton");
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.TabStop = true;
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            resources.ApplyResources(this.bobRadioButton, "bobRadioButton");
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            resources.ApplyResources(this.joeRadioButton, "joeRadioButton");
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // raceTimer
            // 
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bettingParlor);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.bettingParlor.ResumeLayout(false);
            this.bettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.GroupBox bettingParlor;
        private System.Windows.Forms.Label minimumBetLable;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label alBetLable;
        private System.Windows.Forms.Label bobBetLable;
        private System.Windows.Forms.Label joeBetLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.NumericUpDown dogNumber;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Timer raceTimer;
    }
}

