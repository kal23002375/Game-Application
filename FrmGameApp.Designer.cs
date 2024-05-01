namespace ProjectName
{
    partial class FrmGameApp
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
            this.BtnPlayGame = new System.Windows.Forms.Button();
            this.BtnFindOverallWinner = new System.Windows.Forms.Button();
            this.TbxPlayersName = new System.Windows.Forms.TextBox();
            this.CbxGame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblComputerScore = new System.Windows.Forms.Label();
            this.LblPlayerScore = new System.Windows.Forms.Label();
            this.LsvGameStatistics = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnHit = new System.Windows.Forms.Button();
            this.BtnStand = new System.Windows.Forms.Button();
            this.LblPlayersScoreBlackjack = new System.Windows.Forms.Label();
            this.LblCompScoreBlackjack = new System.Windows.Forms.Label();
            this.LblPlayersHand = new System.Windows.Forms.Label();
            this.LblCompsHand = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPlayGame
            // 
            this.BtnPlayGame.Location = new System.Drawing.Point(10, 164);
            this.BtnPlayGame.Name = "BtnPlayGame";
            this.BtnPlayGame.Size = new System.Drawing.Size(75, 23);
            this.BtnPlayGame.TabIndex = 0;
            this.BtnPlayGame.Text = "Play Game";
            this.BtnPlayGame.UseVisualStyleBackColor = true;
            // 
            // BtnFindOverallWinner
            // 
            this.BtnFindOverallWinner.Location = new System.Drawing.Point(10, 419);
            this.BtnFindOverallWinner.Name = "BtnFindOverallWinner";
            this.BtnFindOverallWinner.Size = new System.Drawing.Size(152, 23);
            this.BtnFindOverallWinner.TabIndex = 1;
            this.BtnFindOverallWinner.Text = "Find Overall Winner";
            this.BtnFindOverallWinner.UseVisualStyleBackColor = true;
            // 
            // TbxPlayersName
            // 
            this.TbxPlayersName.Location = new System.Drawing.Point(85, 92);
            this.TbxPlayersName.Name = "TbxPlayersName";
            this.TbxPlayersName.Size = new System.Drawing.Size(121, 23);
            this.TbxPlayersName.TabIndex = 2;
            // 
            // CbxGame
            // 
            this.CbxGame.FormattingEnabled = true;
            this.CbxGame.Location = new System.Drawing.Point(86, 120);
            this.CbxGame.Name = "CbxGame";
            this.CbxGame.Size = new System.Drawing.Size(121, 23);
            this.CbxGame.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pick Game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Computer Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Player Score";
            // 
            // LblComputerScore
            // 
            this.LblComputerScore.AutoSize = true;
            this.LblComputerScore.Location = new System.Drawing.Point(280, 168);
            this.LblComputerScore.Name = "LblComputerScore";
            this.LblComputerScore.Size = new System.Drawing.Size(13, 15);
            this.LblComputerScore.TabIndex = 8;
            this.LblComputerScore.Text = "0";
            // 
            // LblPlayerScore
            // 
            this.LblPlayerScore.AutoSize = true;
            this.LblPlayerScore.Location = new System.Drawing.Point(280, 202);
            this.LblPlayerScore.Name = "LblPlayerScore";
            this.LblPlayerScore.Size = new System.Drawing.Size(13, 15);
            this.LblPlayerScore.TabIndex = 9;
            this.LblPlayerScore.Text = "0";
            // 
            // LsvGameStatistics
            // 
            this.LsvGameStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LsvGameStatistics.GridLines = true;
            this.LsvGameStatistics.Location = new System.Drawing.Point(10, 237);
            this.LsvGameStatistics.Name = "LsvGameStatistics";
            this.LsvGameStatistics.Size = new System.Drawing.Size(457, 161);
            this.LsvGameStatistics.TabIndex = 10;
            this.LsvGameStatistics.UseCompatibleStateImageBehavior = false;
            this.LsvGameStatistics.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Game Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Players Score";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Computers Score";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Winner";
            this.columnHeader4.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Players Hand\r\nSuit Face Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Computers Hand\r\nSuit Face Value";
            // 
            // BtnHit
            // 
            this.BtnHit.Location = new System.Drawing.Point(488, 203);
            this.BtnHit.Name = "BtnHit";
            this.BtnHit.Size = new System.Drawing.Size(75, 23);
            this.BtnHit.TabIndex = 13;
            this.BtnHit.Text = "Hit";
            this.BtnHit.UseVisualStyleBackColor = true;
            // 
            // BtnStand
            // 
            this.BtnStand.Location = new System.Drawing.Point(660, 202);
            this.BtnStand.Name = "BtnStand";
            this.BtnStand.Size = new System.Drawing.Size(75, 23);
            this.BtnStand.TabIndex = 14;
            this.BtnStand.Text = "Stand";
            this.BtnStand.UseVisualStyleBackColor = true;
            // 
            // LblPlayersScoreBlackjack
            // 
            this.LblPlayersScoreBlackjack.AutoSize = true;
            this.LblPlayersScoreBlackjack.Location = new System.Drawing.Point(488, 185);
            this.LblPlayersScoreBlackjack.Name = "LblPlayersScoreBlackjack";
            this.LblPlayersScoreBlackjack.Size = new System.Drawing.Size(45, 15);
            this.LblPlayersScoreBlackjack.TabIndex = 15;
            this.LblPlayersScoreBlackjack.Text = "Score : ";
            // 
            // LblCompScoreBlackjack
            // 
            this.LblCompScoreBlackjack.AutoSize = true;
            this.LblCompScoreBlackjack.Location = new System.Drawing.Point(660, 184);
            this.LblCompScoreBlackjack.Name = "LblCompScoreBlackjack";
            this.LblCompScoreBlackjack.Size = new System.Drawing.Size(45, 15);
            this.LblCompScoreBlackjack.TabIndex = 16;
            this.LblCompScoreBlackjack.Text = "Score : ";
            // 
            // LblPlayersHand
            // 
            this.LblPlayersHand.AutoSize = true;
            this.LblPlayersHand.Location = new System.Drawing.Point(487, 96);
            this.LblPlayersHand.Name = "LblPlayersHand";
            this.LblPlayersHand.Size = new System.Drawing.Size(113, 45);
            this.LblPlayersHand.TabIndex = 17;
            this.LblPlayersHand.Text = "Card Suit and Name\r\nCard Suit and Name\r\nCard Suit and Name\r\n";
            // 
            // LblCompsHand
            // 
            this.LblCompsHand.AutoSize = true;
            this.LblCompsHand.Location = new System.Drawing.Point(659, 96);
            this.LblCompsHand.Name = "LblCompsHand";
            this.LblCompsHand.Size = new System.Drawing.Size(113, 45);
            this.LblCompsHand.TabIndex = 18;
            this.LblCompsHand.Text = "Card Suit and Name\r\nCard Suit and Name\r\nCard Suit and Name\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(337, 64);
            this.label7.TabIndex = 19;
            this.label7.Text = "Games application\r\n-Eriks";
            // 
            // FrmGameApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblCompsHand);
            this.Controls.Add(this.LblPlayersHand);
            this.Controls.Add(this.LblCompScoreBlackjack);
            this.Controls.Add(this.LblPlayersScoreBlackjack);
            this.Controls.Add(this.BtnStand);
            this.Controls.Add(this.BtnHit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LsvGameStatistics);
            this.Controls.Add(this.LblPlayerScore);
            this.Controls.Add(this.LblComputerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxGame);
            this.Controls.Add(this.TbxPlayersName);
            this.Controls.Add(this.BtnFindOverallWinner);
            this.Controls.Add(this.BtnPlayGame);
            this.Name = "FrmGameApp";
            this.Text = "Game App by Eriks Kalnins";
            this.Load += new System.EventHandler(this.FrmGameApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnPlayGame;
        private Button BtnFindOverallWinner;
        private TextBox TbxPlayersName;
        private ComboBox CbxGame;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label LblComputerScore;
        private Label LblPlayerScore;
        private ListView LsvGameStatistics;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label5;
        private Label label6;
        private Button BtnHit;
        private Button BtnStand;
        private Label LblPlayersScore;
        private Label LblCompScore;
        private Label LblPlayersHand;
        private Label LblCompsHand;
        private Label LblPlayersScoreBlackjack;
        private Label LblCompScoreBlackjack;
        private Label label7;
    }
}