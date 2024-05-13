using ProjectName.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectName {
    public partial class FrmGameApp : Form
    {
        /// <summary>
        /// Game App Constructor
        /// </summary>
        public FrmGameApp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to reset interface
        /// a - Set player's name to be empty
        /// b - Deselect game from combo box
        /// c - Disable usage of Combo Box
        /// d - Disable Play game Button
        /// e - Clear list view
        /// f - Disable Hit button
        /// g - Disable Stand button
        /// </summary>
        private void ResetInterface()
        {
            TbxPlayersName.Text = ""; // a
            CbxGame.SelectedIndex = -1; // b
            CbxGame.Enabled = false; // c
            BtnPlayGame.Enabled = false; // d
            LsvGameStatistics.Items.Clear(); // e
            BtnHit.Enabled = false; // f
            BtnStand.Enabled = false; // g
        }
        /// <summary>
        /// Fill combo box function
        /// a - Array holding names of each game
        /// b - Clear items in combo box
        /// c - foreach string in array, add item to combo box
        /// </summary>
        private void FillCbxGame()
        {
            string[] availableGames = { "Dice", "Ten Sided Dice", "Twenty Sided Dice", "Blackjack", "High Card" }; // a
            CbxGame.Items.Clear(); // b
            foreach (string game in availableGames)
                CbxGame.Items.Add(game); // c
        }
        /// <summary>
        /// Load game app window
        /// a. Fill combo box
        /// b. Reset interface
        /// c. Create handlers for events such as play game click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGameApp_Load(object sender, EventArgs e)
        {
            FillCbxGame(); // a
            ResetInterface(); // b
            this.BtnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click); // c
            this.BtnFindOverallWinner.Click += new System.EventHandler(this.BtnFindOverallWinner_Click);
            this.TbxPlayersName.TextChanged += new System.EventHandler(this.TbxPlayersName_TextChanged);
            this.CbxGame.SelectedIndexChanged += new System.EventHandler(this.CbxGame_SelectedIndexChanged);
            this.BtnHit.Click += new System.EventHandler(this.BtnHit_Click);
            this.BtnStand.Click += new System.EventHandler(this.BtnStand_Click);
            /*this.Controls.Add(this.createPicture("sixdiamonds", new Point(600,300)));
            PictureBox pict = this.createPicture("eightclubs", new Point(700, 300));
            this.Controls.Add(pict);
            this.Controls.Remove(pict);*/
        }


        /// <summary>
        /// Handler for combo box changing
        /// If a game is selected, enable play game button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxGame_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (CbxGame.SelectedIndex != -1)
                BtnPlayGame.Enabled = true;
        }
        /// <summary>
        /// Text box player's name handler
        /// If length of text then enable combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxPlayersName_TextChanged(object? sender, EventArgs e)
        {
            if (TbxPlayersName.Text.Length > 1) // if user inputs something, enable combo box to choose game
            {
                CbxGame.Enabled = true; //a
            }
        }
        /// <summary>
        /// Find overall winner handler
        /// a - Run display overall game result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFindOverallWinner_Click(object? sender, EventArgs e)
        {
            DisplayOverallGameResult(); //a
        }

        // global variable declaration
        public string GameName = "";
        public string PlayersName = "";
        public int PlayersScore = 0;
        public int ComputerScore = 0;
        public string Feedback = "";
        public string Winner = "";

        public Blackjack blackjack;
        /// <summary>
        /// Button play game handler
        /// a - Grab player's name
        /// b - Grab game name
        /// c - Run play game with game name
        /// d - Find Game winner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlayGame_Click(object? sender, EventArgs e)
        {
            PlayersName = TbxPlayersName.Text.ToString(); // a
            GameName = CbxGame.Text.ToString(); // b
            PlayGame(GameName); // c
            Feedback = FindGameWinner(); // d
        }
        /// <summary>
        /// Display overall game result function
        /// a - variables
        /// b - foreach item in the list view
        /// ba - Grab the name of the winner
        /// bb - If player won then increment player wins, else if winner = Computer increment Computer wins
        /// c - If players wins are greater than computer then show that player is winning
        /// d - If players wins are less than computer then show computer is winning
        /// e - If scores are equal, show that they are drawn
        /// f - Run message box showing result string
        /// </summary>
        private void DisplayOverallGameResult()
        {
            //a
            int playerWins = 0;
            int computerWins = 0;
            string result = "";
            int numOfGames = LsvGameStatistics.Items.Count;

            foreach (ListViewItem element in LsvGameStatistics.Items)//b
            {
                result = element.SubItems[3].Text;//ba
                if (result.StartsWith(PlayersName)) //bb
                    playerWins++;
                else if (result.StartsWith("Computer"))
                    computerWins++;
            }

            if (playerWins > computerWins)//c
                result = $"{PlayersName} wins as they won {playerWins} games which is higher than {computerWins}";
            else if (playerWins < computerWins)//d
                result = $"Computer wins as they won {computerWins} games which is higher than {playerWins}";
            if (playerWins == computerWins)//e
                result = $"Draw as both won {computerWins} games";

            MessageBox.Show(result, "Overall Result");//f
        }
        /// <summary>
        /// Display game result function
        /// a - Turn the game's feedback into a string array
        /// b - Create a new list view item using array
        /// c - Add the list view item to the control
        /// </summary>
        private void DisplayGameResult()
        {
            MessageBox.Show(Feedback, "Game Result");
            string[] row = { GameName, PlayersScore.ToString(), ComputerScore.ToString(), Winner }; //a
            var listViewItem = new ListViewItem(row); //b
            LsvGameStatistics.Items.Add(listViewItem); //c
        }
        /// <summary>
        /// Find game winner function
        /// Returns the winner's name and a feedback string
        /// a - Handles a draw
        /// b - Handles if player's score is greater than computer
        /// c - Handles if player's score is less than computer
        /// </summary>
        /// <returns></returns>
        private string FindGameWinner()
        {
            string feedback = "";
            if (PlayersScore == ComputerScore) // a
            {
                feedback = $"Draw as {PlayersScore} was equal to {ComputerScore}";
                Winner = "Draw";
            }
            else if (PlayersScore > ComputerScore) // b
            {
                feedback = $"{PlayersName} wins as {PlayersScore} is higher than {ComputerScore}";
                Winner = PlayersName;
            }
            else if (PlayersScore < ComputerScore) // c
            {
                feedback = $"{PlayersName} loses as {PlayersScore} is lower than {ComputerScore}";
                Winner = "Computer";
            }
            return feedback;
        }
        /// <summary>
        /// Play game function using game name as parameter
        /// a - Try catch statement to handle not implemented game errors
        /// b - Switch case statement for running a function if a game name is found
        /// c - Run Dice Game function with 6 as an argument for normal dice game
        /// d - Run Dice game function with 10 as an argument for 10 sided dice game
        /// e - Run Dice game function with 20 as an argument for 20 sided dice game
        /// f - Play blackjack function
        /// g - Play high card function
        /// </summary>
        /// <param name="gameName"></param>
        private void PlayGame(string gameName)
        {
            try
            {
                switch (gameName) // b
                {
                    case "Dice":
                        PlayDiceGame(6); break; // c
                    case "Ten Sided Dice":
                        PlayDiceGame(10); break; // d
                    case "Twenty Sided Dice":
                        PlayDiceGame(20); break; // e
                    case "Blackjack":
                        PlayBlackjack(); break; // f
                    case "High Card":
                        PlayHighCard(); break; // g
                    default:
                        MessageBox.Show("Game Not Implemented", "Error"); break; // h
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented Correctly " + ex.Message, "Exception Error"); // a
            }
        }
        private PictureBox createPicture(string card, Point loc)
        {
            PictureBox picture = new PictureBox();
            picture.Size = new Size(50, 100);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Image = (Image)Properties.Resources.ResourceManager.GetObject(card);
            picture.Location = loc;
            return picture;
        }
        /// <summary>
        /// Play blackjack function
        /// a - Labels storing blackjack information stored as an array
        /// b - Clear the labels storing blackjack information
        /// c - Disable play game button
        /// d - Enable hit button
        /// e - Enable stand button
        /// f - Create a new instance of blackjack using displays as an argument
        /// g - Run update display
        /// </summary>
        private void PlayBlackjack()
        {
            (Label, Label) Displays = (LblPlayersScoreBlackjack, LblCompScoreBlackjack); // a
            Displays.Item1.Text = ""; // b
            Displays.Item2.Text = "";
            BtnPlayGame.Enabled = false; // c
            BtnHit.Enabled = true; // d
            BtnStand.Enabled = true; // e
            blackjack = new Blackjack(Displays); // f
            blackjack.UpdateDisplay(); // g
            UpdateBlackjack();
        }
        /// <summary>
        /// Handler for the hit button for blackjack
        /// a - If when the player hits and they go bust, it will return true
        /// b - Run stand if the player is bust
        /// c - Update game display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHit_Click(object? sender, EventArgs e)
        {
            if (blackjack.Hit()) //a
            {
                Stand(); // b
            }
            blackjack.UpdateDisplay(); // c
            UpdateBlackjack();
        }
        private void UpdateBlackjack()
        {
            PnlPlayersHand.Controls.Clear();
            PnlComputersHand.Controls.Clear();
            foreach (var pict in blackjack.ReturnPictures().Item1)
            {
                PnlPlayersHand.Controls.Add(pict);
                pict.BringToFront();
            }
            foreach (var pict in blackjack.ReturnPictures().Item2)
            {
                PnlComputersHand.Controls.Add(pict);
                pict.BringToFront();
            }
        }
        /// <summary>
        /// Handler for the stand button in blackjack
        /// a - Run stand function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStand_Click(object? sender, EventArgs e)
        {
            Stand(); //a
            UpdateBlackjack();
        }
        /// <summary>
        /// Stand function to handle if the game has to stand
        /// a - Set the global variables to returned values when stand is run in the blackjack object
        /// b - If the winner is player, set the winner to the player's name
        /// c - Display game result
        /// d - Disable hit and stand button, enable play game button
        /// </summary>
        private void Stand()
        {
            (Winner, Feedback, PlayersScore, ComputerScore) = blackjack.Stand(); //a
            if (Winner == "Player") //b
                Winner = PlayersName;
            DisplayGameResult(); //c
            BtnHit.Enabled = false; //d
            BtnStand.Enabled = false;
            BtnPlayGame.Enabled = true;
        }
        /// <summary>
        /// Play high card function
        /// a - Create a deck and shuffle it
        /// b - Create a card for the player and computer and deal from the deck
        /// c - Grab the value of the card and store it in global variable
        /// d - Set feedback to find game winner result
        /// e - Display game result
        /// </summary>
        private void PlayHighCard()
        {
            Deck GameDeck = new Deck(); // a
            GameDeck.ShuffleDeck();
            PlayingCard PlayersCard = GameDeck.Deal(); //b
            PlayingCard ComputersCard = GameDeck.Deal();
            PlayersScore = PlayersCard.Value(); //c
            ComputerScore = ComputersCard.Value();
            Feedback = FindGameWinner(); //d
            DisplayGameResult(); //e
        }


        /// <summary>
        /// Play Dice Game function
        /// a - Exception handling in the case of an error
        /// b - Create dice for the computer and player using the sides argument
        /// c - Store the numbers from the dice in the scores variables
        /// d - Get feedback from the dice game
        /// e - Display game result
        /// </summary>
        /// <param name="sides"></param>
        private void PlayDiceGame(int sides)
        {
            try //a
            {
                Dice playerDice = new Dice(sides); //b
                Dice computerDice = new Dice(sides);
                PlayersScore = playerDice.Num; //c
                ComputerScore = computerDice.Num;
                Feedback = FindGameWinner(); //d
                DisplayGameResult(); //e
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented Correctly " + ex.Message, "Exception Error");
            }
        }

        private void PnlCardDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
        /*private char GetReply(string prompt)
{
string temp = InputBox.Show("Continue?", prompt); // a
if (temp.ToUpper().StartsWith('Y'))
return 'Y'; // b
else
return 'N'; // c
}*/
        /*/// <summary>
        /// Play game button handler function
        /// a - Grab players name as a string
        /// b - Grab game name from combo box
        /// c - Run play game function with game name
        /// d - Run find game winner to grab feedback
        /// e - Display game result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlayGameV2_Click(object? sender, EventArgs e)
        {
            PlayersName = TbxPlayersName.Text.ToString(); //a 
            GameName = CbxGame.TextS.ToString();  // b
            PlayGame(GameName); // c
            Feedback = FindGameWinner(); // d
            DisplayGameResult(); // e
        }*/
        /*private void PlayGame(string sides)
        {
            DiceImproved playerDice = new DiceImproved(Convert.ToInt32(sides));
            DiceImproved computerDice = new DiceImproved(Convert.ToInt32(sides));
            PlayersScore = playerDice.Num;
            ComputerScore = computerDice.Num;
        }*/
        /*private void PlayTwentySidedDiceGame()
        {
            try
            {
                TwentySidedDice playerDice = new TwentySidedDice("Blue");
                TwentySidedDice computerDice = new TwentySidedDice("Red");
                PlayersScore = playerDice.Num;
                ComputerScore = computerDice.Num;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented Correctly " + ex.Message, "Exception Error");
            }
        }*/

        /*private void PlayTenSidedDiceGame()
        {
            try
            {
                TenSidedDice playerDice = new TenSidedDice("Blue");
                TenSidedDice computerDice = new TenSidedDice("Red");
                PlayersScore = playerDice.Num;
                ComputerScore = computerDice.Num;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented Correctly " + ex.Message, "Exception Error");
            }
        }*/
        /*
        public Deck GameDeck = new Deck();
        public List<PlayingCard> PlayersCards = new List<PlayingCard>();
        public List<PlayingCard> ComputerCards = new List<PlayingCard>();
        private void PlayBlackjack()
        {
            BtnPlayGame.Enabled = false;
            BtnHit.Enabled = true;
            BtnStand.Enabled = true;
            GameDeck.ShuffleDeck();
            PlayersScore = 0;
            ComputerScore = 0;
            for (int i = 0; i<2; i++)
            {
                PlayersCards.Add(GameDeck.Deal());
                ComputerCards.Add(GameDeck.Deal());
            }
            foreach (var card in PlayersCards)
            {
                int cardValue = (int)Enum.Parse(typeof(Faces), card.face);
                if (card.face == "Ace" && PlayersScore <= 10)
                {
                    PlayersScore += 11;
                }
                else
                {
                    PlayersScore += (int)Enum.Parse(typeof(Faces), card.face);
                }
            }
            foreach (var card in ComputerCards)
            {
                int cardValue = (int)Enum.Parse(typeof(Faces), card.face);
                if (card.face == "Ace" && ComputerScore <= 10)
                {
                    ComputerScore += 11;
                }
                else
                {
                    ComputerScore += (int)Enum.Parse(typeof(Faces), card.face);
                }
            }
            LblCompScoreBlackjack.Text = ComputerScore.ToString();
            LblPlayersScoreBlackjack.Text = PlayersScore.ToString();
            UpdateBlackjackDisplay();
        }
        private void BtnHit_Click(object? sender, EventArgs e)
        {
            PlayersCards.Add(GameDeck.Deal());
            int cardValue = (int)Enum.Parse(typeof(Faces), PlayersCards.Last().face);
            if (PlayersCards.Last().face == "Ace" && PlayersScore <= 10)
            {
                PlayersScore += 11;
            }
            else
            {
                PlayersScore += (int)Enum.Parse(typeof(Faces), PlayersCards.Last().face);
            }
            if (PlayersScore> 21)
            {
                Stand();
            }
            UpdateBlackjackDisplay();
        }
        private void Stand()
        {
            while (ComputerScore < 17 && ComputerScore < PlayersScore)
            {
                ComputerCards.Add(GameDeck.Deal());
                int cardValue = (int)Enum.Parse(typeof(Faces), ComputerCards.Last().face);
                if (ComputerCards.Last().face == "Ace" && ComputerScore <= 10)
                {
                    ComputerScore += 11;
                }
                ComputerScore += (int)Enum.Parse(typeof(Faces), ComputerCards.Last().face);
            }
            if (PlayersScore > 21)
            {
                Feedback = "Bust!";
                Winner = "Computer";
            }
            else if (ComputerScore > 21)
            {
                Feedback = "Computer went bust!";
                Winner = PlayersName;
            }
            else if (PlayersScore > ComputerScore)
            {
                Feedback = $"{PlayersName} wins";
                Winner = PlayersName;
            }
            else if (PlayersScore < ComputerScore)
            {
                Feedback = "Computer wins";
                Winner = "Computer";
            }
            else if (PlayersCards.Count > ComputerCards.Count)
            {
                Feedback = $"{PlayersName} wins, equal score but you have more cards";
                Winner = PlayersName;
            }
            else if (PlayersCards.Count < ComputerCards.Count)
            {
                Feedback = "Computer wins, equal score but you have less cards";
                Winner = "Computer";
            }
            else
            {
                Winner = "Draw";
                Feedback = "Error";
            }
            BtnPlayGame.Enabled = true;
            BtnHit.Enabled = false;
            BtnStand.Enabled = false;
            UpdateBlackjackDisplay();
            DisplayGameResult();
            foreach (var card in PlayersCards)
            {
                GameDeck.PlaceIntoDeck(card);
            }
            foreach (var card in ComputerCards)
            {
                GameDeck.PlaceIntoDeck(card);
            }
            PlayersCards.Clear();
            ComputerCards.Clear();
        }
        private void BtnStand_Click(object? sender, EventArgs e)
        {
            Stand();
        }
        private void UpdateBlackjackDisplay()
        {
            LblCompsHand.Text = "";
            LblPlayersHand.Text = "";
            foreach (var card in PlayersCards)
            {
                LblPlayersHand.Text += card.face + " : " + card.suit+"\n";
            }
            foreach (var card in ComputerCards)
            {
                LblCompsHand.Text += card.face + " : " + card.suit + "\n";
            }
            LblCompScoreBlackjack.Text = ComputerScore.ToString();
            LblPlayersScoreBlackjack.Text = PlayersScore.ToString();
        }*/


    }
}
