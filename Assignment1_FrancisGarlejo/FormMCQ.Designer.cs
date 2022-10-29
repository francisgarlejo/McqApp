namespace Assignment1_FrancisGarlejo
{
    partial class FormMCQ
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMCQ));
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnOpt1 = new System.Windows.Forms.Button();
            this.btnOpt2 = new System.Windows.Forms.Button();
            this.btnOpt3 = new System.Windows.Forms.Button();
            this.btnOpt4 = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblColumnHead = new System.Windows.Forms.Label();
            this.lblLevel7 = new System.Windows.Forms.Label();
            this.lblLevel6 = new System.Windows.Forms.Label();
            this.lblLevel5 = new System.Windows.Forms.Label();
            this.lblLevel4 = new System.Windows.Forms.Label();
            this.lblLevel3 = new System.Windows.Forms.Label();
            this.lblLevel2 = new System.Windows.Forms.Label();
            this.lblLevel1 = new System.Windows.Forms.Label();
            this.btnFiftyFifty = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblCountdownTimer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Black;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(3, 9);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(153, 25);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(51, 265);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(173, 25);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Ask your Question";
            // 
            // btnOpt1
            // 
            this.btnOpt1.Location = new System.Drawing.Point(56, 334);
            this.btnOpt1.Name = "btnOpt1";
            this.btnOpt1.Size = new System.Drawing.Size(99, 59);
            this.btnOpt1.TabIndex = 2;
            this.btnOpt1.Tag = "1";
            this.btnOpt1.Text = "Option 1";
            this.btnOpt1.UseVisualStyleBackColor = true;
            this.btnOpt1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btnOpt2
            // 
            this.btnOpt2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnOpt2.Location = new System.Drawing.Point(369, 334);
            this.btnOpt2.Name = "btnOpt2";
            this.btnOpt2.Size = new System.Drawing.Size(99, 59);
            this.btnOpt2.TabIndex = 3;
            this.btnOpt2.Tag = "2";
            this.btnOpt2.Text = "Option 2";
            this.btnOpt2.UseVisualStyleBackColor = false;
            this.btnOpt2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btnOpt3
            // 
            this.btnOpt3.Location = new System.Drawing.Point(56, 418);
            this.btnOpt3.Name = "btnOpt3";
            this.btnOpt3.Size = new System.Drawing.Size(99, 59);
            this.btnOpt3.TabIndex = 4;
            this.btnOpt3.Tag = "3";
            this.btnOpt3.Text = "Option 3";
            this.btnOpt3.UseVisualStyleBackColor = true;
            this.btnOpt3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btnOpt4
            // 
            this.btnOpt4.Location = new System.Drawing.Point(369, 418);
            this.btnOpt4.Name = "btnOpt4";
            this.btnOpt4.Size = new System.Drawing.Size(99, 59);
            this.btnOpt4.TabIndex = 5;
            this.btnOpt4.Tag = "4";
            this.btnOpt4.Text = "Option 4";
            this.btnOpt4.UseVisualStyleBackColor = true;
            this.btnOpt4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Black;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(3, 47);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(68, 20);
            this.lblPoints.TabIndex = 6;
            this.lblPoints.Text = "Points:";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblColumnHead
            // 
            this.lblColumnHead.AutoSize = true;
            this.lblColumnHead.BackColor = System.Drawing.Color.Black;
            this.lblColumnHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnHead.ForeColor = System.Drawing.Color.White;
            this.lblColumnHead.Location = new System.Drawing.Point(3, 77);
            this.lblColumnHead.Name = "lblColumnHead";
            this.lblColumnHead.Size = new System.Drawing.Size(273, 20);
            this.lblColumnHead.TabIndex = 8;
            this.lblColumnHead.Text = "Question No.                Points        ";
            // 
            // lblLevel7
            // 
            this.lblLevel7.AutoSize = true;
            this.lblLevel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel7.Location = new System.Drawing.Point(32, 112);
            this.lblLevel7.Name = "lblLevel7";
            this.lblLevel7.Size = new System.Drawing.Size(229, 20);
            this.lblLevel7.TabIndex = 9;
            this.lblLevel7.Text = "7                          100000000";
            // 
            // lblLevel6
            // 
            this.lblLevel6.AutoSize = true;
            this.lblLevel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel6.Location = new System.Drawing.Point(32, 142);
            this.lblLevel6.Name = "lblLevel6";
            this.lblLevel6.Size = new System.Drawing.Size(225, 20);
            this.lblLevel6.TabIndex = 10;
            this.lblLevel6.Text = "6                           10000000";
            // 
            // lblLevel5
            // 
            this.lblLevel5.AutoSize = true;
            this.lblLevel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel5.Location = new System.Drawing.Point(32, 174);
            this.lblLevel5.Name = "lblLevel5";
            this.lblLevel5.Size = new System.Drawing.Size(221, 20);
            this.lblLevel5.TabIndex = 11;
            this.lblLevel5.Text = "5                            1000000";
            // 
            // lblLevel4
            // 
            this.lblLevel4.AutoSize = true;
            this.lblLevel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel4.Location = new System.Drawing.Point(32, 205);
            this.lblLevel4.Name = "lblLevel4";
            this.lblLevel4.Size = new System.Drawing.Size(217, 20);
            this.lblLevel4.TabIndex = 12;
            this.lblLevel4.Text = "4                             100000";
            // 
            // lblLevel3
            // 
            this.lblLevel3.AutoSize = true;
            this.lblLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel3.Location = new System.Drawing.Point(32, 237);
            this.lblLevel3.Name = "lblLevel3";
            this.lblLevel3.Size = new System.Drawing.Size(213, 20);
            this.lblLevel3.TabIndex = 13;
            this.lblLevel3.Text = "3                              10000";
            // 
            // lblLevel2
            // 
            this.lblLevel2.AutoSize = true;
            this.lblLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel2.Location = new System.Drawing.Point(32, 271);
            this.lblLevel2.Name = "lblLevel2";
            this.lblLevel2.Size = new System.Drawing.Size(204, 20);
            this.lblLevel2.TabIndex = 14;
            this.lblLevel2.Text = "2                              1000";
            // 
            // lblLevel1
            // 
            this.lblLevel1.AutoSize = true;
            this.lblLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel1.Location = new System.Drawing.Point(32, 303);
            this.lblLevel1.Name = "lblLevel1";
            this.lblLevel1.Size = new System.Drawing.Size(200, 20);
            this.lblLevel1.TabIndex = 15;
            this.lblLevel1.Text = "1                               100";
            // 
            // btnFiftyFifty
            // 
            this.btnFiftyFifty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFiftyFifty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiftyFifty.Location = new System.Drawing.Point(143, 518);
            this.btnFiftyFifty.Name = "btnFiftyFifty";
            this.btnFiftyFifty.Size = new System.Drawing.Size(103, 62);
            this.btnFiftyFifty.TabIndex = 18;
            this.btnFiftyFifty.Text = "50:50";
            this.btnFiftyFifty.UseVisualStyleBackColor = false;
            this.btnFiftyFifty.Click += new System.EventHandler(this.btnFiftyFifty_Click);
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(275, 518);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(103, 62);
            this.btnHint.TabIndex = 19;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblCountdownTimer
            // 
            this.lblCountdownTimer.AutoSize = true;
            this.lblCountdownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdownTimer.Location = new System.Drawing.Point(229, 388);
            this.lblCountdownTimer.Name = "lblCountdownTimer";
            this.lblCountdownTimer.Size = new System.Drawing.Size(51, 25);
            this.lblCountdownTimer.TabIndex = 20;
            this.lblCountdownTimer.Text = "1:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblPlayerName);
            this.panel1.Controls.Add(this.lblPoints);
            this.panel1.Controls.Add(this.lblLevel4);
            this.panel1.Controls.Add(this.lblColumnHead);
            this.panel1.Controls.Add(this.lblLevel3);
            this.panel1.Controls.Add(this.lblLevel7);
            this.panel1.Controls.Add(this.lblLevel5);
            this.panel1.Controls.Add(this.lblLevel1);
            this.panel1.Controls.Add(this.lblLevel2);
            this.panel1.Controls.Add(this.lblLevel6);
            this.panel1.Location = new System.Drawing.Point(552, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 326);
            this.panel1.TabIndex = 22;
            // 
            // FormMCQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(888, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCountdownTimer);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnFiftyFifty);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpt4);
            this.Controls.Add(this.btnOpt3);
            this.Controls.Add(this.btnOpt2);
            this.Controls.Add(this.btnOpt1);
            this.Controls.Add(this.lblQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMCQ";
            this.Tag = "";
            this.Text = "MCQ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnOpt1;
        private System.Windows.Forms.Button btnOpt2;
        private System.Windows.Forms.Button btnOpt3;
        private System.Windows.Forms.Button btnOpt4;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblColumnHead;
        private System.Windows.Forms.Label lblLevel7;
        private System.Windows.Forms.Label lblLevel6;
        private System.Windows.Forms.Label lblLevel5;
        private System.Windows.Forms.Label lblLevel4;
        private System.Windows.Forms.Label lblLevel3;
        private System.Windows.Forms.Label lblLevel2;
        private System.Windows.Forms.Label lblLevel1;
        private System.Windows.Forms.Button btnFiftyFifty;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblCountdownTimer;
        private System.Windows.Forms.Panel panel1;
    }
}