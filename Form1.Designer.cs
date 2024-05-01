namespace ProjectName
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
            this.TbxFirstName = new System.Windows.Forms.TextBox();
            this.TbxSurname = new System.Windows.Forms.TextBox();
            this.TbxTemperature = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.TbxMark = new System.Windows.Forms.TextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.CbxGuess = new System.Windows.Forms.ComboBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnGradeBasedOnMark = new System.Windows.Forms.Button();
            this.BtnPlayGuessingGame = new System.Windows.Forms.Button();
            this.BtnGuessingGame_P = new System.Windows.Forms.Button();
            this.BtnPlayBadDice = new System.Windows.Forms.Button();
            this.BtnPlayBetterDice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxFirstName
            // 
            this.TbxFirstName.Location = new System.Drawing.Point(121, 40);
            this.TbxFirstName.Name = "TbxFirstName";
            this.TbxFirstName.Size = new System.Drawing.Size(121, 23);
            this.TbxFirstName.TabIndex = 0;
            // 
            // TbxSurname
            // 
            this.TbxSurname.Location = new System.Drawing.Point(121, 69);
            this.TbxSurname.Name = "TbxSurname";
            this.TbxSurname.Size = new System.Drawing.Size(121, 23);
            this.TbxSurname.TabIndex = 1;
            // 
            // TbxTemperature
            // 
            this.TbxTemperature.Location = new System.Drawing.Point(121, 98);
            this.TbxTemperature.Name = "TbxTemperature";
            this.TbxTemperature.Size = new System.Drawing.Size(121, 23);
            this.TbxTemperature.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 43);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 15);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Enter First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 72);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(84, 15);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Enter Surname";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(12, 101);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(103, 15);
            this.lblTemperature.TabIndex = 5;
            this.lblTemperature.Text = "Enter Temperature";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(12, 130);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(64, 15);
            this.lblMark.TabIndex = 6;
            this.lblMark.Text = "Enter Mark";
            // 
            // TbxMark
            // 
            this.TbxMark.Location = new System.Drawing.Point(121, 127);
            this.TbxMark.Name = "TbxMark";
            this.TbxMark.Size = new System.Drawing.Size(121, 23);
            this.TbxMark.TabIndex = 7;
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(12, 159);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(68, 15);
            this.lblGuess.TabIndex = 8;
            this.lblGuess.Text = "Enter Guess";
            // 
            // CbxGuess
            // 
            this.CbxGuess.FormattingEnabled = true;
            this.CbxGuess.Location = new System.Drawing.Point(121, 156);
            this.CbxGuess.Name = "CbxGuess";
            this.CbxGuess.Size = new System.Drawing.Size(121, 23);
            this.CbxGuess.TabIndex = 9;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(313, 39);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(159, 23);
            this.BtnPlay.TabIndex = 10;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnGradeBasedOnMark
            // 
            this.BtnGradeBasedOnMark.Location = new System.Drawing.Point(313, 68);
            this.BtnGradeBasedOnMark.Name = "BtnGradeBasedOnMark";
            this.BtnGradeBasedOnMark.Size = new System.Drawing.Size(159, 23);
            this.BtnGradeBasedOnMark.TabIndex = 11;
            this.BtnGradeBasedOnMark.Text = "Grade based on Mark";
            this.BtnGradeBasedOnMark.UseVisualStyleBackColor = true;
            this.BtnGradeBasedOnMark.Click += new System.EventHandler(this.BtnGradeBasedOnMark_Click);
            // 
            // BtnPlayGuessingGame
            // 
            this.BtnPlayGuessingGame.Location = new System.Drawing.Point(313, 97);
            this.BtnPlayGuessingGame.Name = "BtnPlayGuessingGame";
            this.BtnPlayGuessingGame.Size = new System.Drawing.Size(159, 23);
            this.BtnPlayGuessingGame.TabIndex = 12;
            this.BtnPlayGuessingGame.Text = "Play Guessing Game V1";
            this.BtnPlayGuessingGame.UseVisualStyleBackColor = true;
            this.BtnPlayGuessingGame.Click += new System.EventHandler(this.BtnPlayGuessingGame_Click);
            // 
            // BtnGuessingGame_P
            // 
            this.BtnGuessingGame_P.Location = new System.Drawing.Point(100, 195);
            this.BtnGuessingGame_P.Name = "BtnGuessingGame_P";
            this.BtnGuessingGame_P.Size = new System.Drawing.Size(159, 23);
            this.BtnGuessingGame_P.TabIndex = 13;
            this.BtnGuessingGame_P.Text = "Play Guessing Game P";
            this.BtnGuessingGame_P.UseVisualStyleBackColor = true;
            this.BtnGuessingGame_P.Click += new System.EventHandler(this.BtnGuessingGame_P_Click);
            // 
            // BtnPlayBadDice
            // 
            this.BtnPlayBadDice.Location = new System.Drawing.Point(100, 224);
            this.BtnPlayBadDice.Name = "BtnPlayBadDice";
            this.BtnPlayBadDice.Size = new System.Drawing.Size(160, 23);
            this.BtnPlayBadDice.TabIndex = 14;
            this.BtnPlayBadDice.Text = "Play Bad Dice Game";
            this.BtnPlayBadDice.UseVisualStyleBackColor = true;
            // 
            // BtnPlayBetterDice
            // 
            this.BtnPlayBetterDice.Location = new System.Drawing.Point(101, 253);
            this.BtnPlayBetterDice.Name = "BtnPlayBetterDice";
            this.BtnPlayBetterDice.Size = new System.Drawing.Size(159, 23);
            this.BtnPlayBetterDice.TabIndex = 15;
            this.BtnPlayBetterDice.Text = "Play 6 Sided Dice Game";
            this.BtnPlayBetterDice.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPlayBetterDice);
            this.Controls.Add(this.BtnPlayBadDice);
            this.Controls.Add(this.BtnGuessingGame_P);
            this.Controls.Add(this.BtnPlayGuessingGame);
            this.Controls.Add(this.BtnGradeBasedOnMark);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.CbxGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.TbxMark);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.TbxTemperature);
            this.Controls.Add(this.TbxSurname);
            this.Controls.Add(this.TbxFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TbxFirstName;
        private TextBox TbxSurname;
        private TextBox TbxTemperature;
        private Label lblFirstName;
        private Label lblSurname;
        private Label lblTemperature;
        private Label lblMark;
        private TextBox TbxMark;
        private Label lblGuess;
        private ComboBox CbxGuess;
        private Button BtnPlay;
        private Button BtnGradeBasedOnMark;
        private Button BtnPlayGuessingGame;
        private Button BtnGuessingGame_P;
        private Button BtnPlayBadDice;
        private Button BtnPlayBetterDice;
    }
}