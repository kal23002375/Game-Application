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
            BtnPlayGame = new Button();
            BtnFindOverallWinner = new Button();
            TbxPlayersName = new TextBox();
            CbxGame = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            LsvGameStatistics = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label5 = new Label();
            label6 = new Label();
            BtnHit = new Button();
            BtnStand = new Button();
            LblPlayersScoreBlackjack = new Label();
            LblCompScoreBlackjack = new Label();
            label7 = new Label();
            PnlPlayersHand = new Panel();
            PnlComputersHand = new Panel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnPlayGame
            // 
            BtnPlayGame.Location = new Point(10, 164);
            BtnPlayGame.Name = "BtnPlayGame";
            BtnPlayGame.Size = new Size(75, 23);
            BtnPlayGame.TabIndex = 0;
            BtnPlayGame.Text = "Play Game";
            BtnPlayGame.UseVisualStyleBackColor = true;
            // 
            // BtnFindOverallWinner
            // 
            BtnFindOverallWinner.Location = new Point(10, 419);
            BtnFindOverallWinner.Name = "BtnFindOverallWinner";
            BtnFindOverallWinner.Size = new Size(152, 23);
            BtnFindOverallWinner.TabIndex = 1;
            BtnFindOverallWinner.Text = "Find Overall Winner";
            BtnFindOverallWinner.UseVisualStyleBackColor = true;
            // 
            // TbxPlayersName
            // 
            TbxPlayersName.Location = new Point(85, 92);
            TbxPlayersName.Name = "TbxPlayersName";
            TbxPlayersName.Size = new Size(121, 23);
            TbxPlayersName.TabIndex = 2;
            // 
            // CbxGame
            // 
            CbxGame.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxGame.FormattingEnabled = true;
            CbxGame.Location = new Point(86, 120);
            CbxGame.Name = "CbxGame";
            CbxGame.Size = new Size(121, 23);
            CbxGame.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 100);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 124);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Pick Game";
            // 
            // LsvGameStatistics
            // 
            LsvGameStatistics.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            LsvGameStatistics.GridLines = true;
            LsvGameStatistics.Location = new Point(10, 193);
            LsvGameStatistics.Name = "LsvGameStatistics";
            LsvGameStatistics.Size = new Size(403, 205);
            LsvGameStatistics.TabIndex = 10;
            LsvGameStatistics.UseCompatibleStateImageBehavior = false;
            LsvGameStatistics.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Game Name";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Players Score";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Computers Score";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Winner";
            columnHeader4.Width = 100;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(72, 120, 96);
            label5.Location = new Point(421, 9);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 11;
            label5.Text = "Players Hand\r";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(72, 120, 96);
            label6.Location = new Point(422, 242);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 12;
            label6.Text = "Computers Hand\r";
            // 
            // BtnHit
            // 
            BtnHit.Location = new Point(7, 49);
            BtnHit.Name = "BtnHit";
            BtnHit.Size = new Size(75, 23);
            BtnHit.TabIndex = 13;
            BtnHit.Text = "Hit";
            BtnHit.UseVisualStyleBackColor = true;
            // 
            // BtnStand
            // 
            BtnStand.Location = new Point(88, 49);
            BtnStand.Name = "BtnStand";
            BtnStand.Size = new Size(75, 23);
            BtnStand.TabIndex = 14;
            BtnStand.Text = "Stand";
            BtnStand.UseVisualStyleBackColor = true;
            // 
            // LblPlayersScoreBlackjack
            // 
            LblPlayersScoreBlackjack.AutoSize = true;
            LblPlayersScoreBlackjack.BackColor = Color.FromArgb(72, 120, 96);
            LblPlayersScoreBlackjack.Location = new Point(421, 32);
            LblPlayersScoreBlackjack.Name = "LblPlayersScoreBlackjack";
            LblPlayersScoreBlackjack.Size = new Size(45, 15);
            LblPlayersScoreBlackjack.TabIndex = 15;
            LblPlayersScoreBlackjack.Text = "Score : ";
            // 
            // LblCompScoreBlackjack
            // 
            LblCompScoreBlackjack.AutoSize = true;
            LblCompScoreBlackjack.BackColor = Color.FromArgb(72, 120, 96);
            LblCompScoreBlackjack.Location = new Point(422, 265);
            LblCompScoreBlackjack.Name = "LblCompScoreBlackjack";
            LblCompScoreBlackjack.Size = new Size(45, 15);
            LblCompScoreBlackjack.TabIndex = 16;
            LblCompScoreBlackjack.Text = "Score : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Console", 24F, FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(10, 9);
            label7.Name = "label7";
            label7.Size = new Size(337, 64);
            label7.TabIndex = 19;
            label7.Text = "Games application\r\n-Eriks";
            // 
            // PnlPlayersHand
            // 
            PnlPlayersHand.BackColor = Color.FromArgb(115, 171, 143);
            PnlPlayersHand.Location = new Point(422, 79);
            PnlPlayersHand.Name = "PnlPlayersHand";
            PnlPlayersHand.Size = new Size(560, 160);
            PnlPlayersHand.TabIndex = 20;
            PnlPlayersHand.Paint += PnlCardDisplay_Paint;
            // 
            // PnlComputersHand
            // 
            PnlComputersHand.BackColor = Color.FromArgb(115, 171, 143);
            PnlComputersHand.Location = new Point(422, 282);
            PnlComputersHand.Name = "PnlComputersHand";
            PnlComputersHand.Size = new Size(560, 160);
            PnlComputersHand.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(72, 120, 96);
            panel1.Controls.Add(BtnStand);
            panel1.Controls.Add(BtnHit);
            panel1.Location = new Point(415, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 453);
            panel1.TabIndex = 21;
            // 
            // FrmGameApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Silver;
            ClientSize = new Size(987, 450);
            Controls.Add(PnlComputersHand);
            Controls.Add(PnlPlayersHand);
            Controls.Add(label7);
            Controls.Add(LblCompScoreBlackjack);
            Controls.Add(LblPlayersScoreBlackjack);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LsvGameStatistics);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CbxGame);
            Controls.Add(TbxPlayersName);
            Controls.Add(BtnFindOverallWinner);
            Controls.Add(BtnPlayGame);
            Controls.Add(panel1);
            Name = "FrmGameApp";
            Text = "Game App by Eriks Kalnins";
            Load += FrmGameApp_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Label LblPlayersScoreBlackjack;
        private Label LblCompScoreBlackjack;
        private Label label7;
        private Panel PnlPlayersHand;
        private Panel PnlComputersHand;
        private Panel panel1;
    }
}