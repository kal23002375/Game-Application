using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName
{
    /// <summary>
    /// Blackjack class to seperate the code for blackjack
    /// 1 - Attributes
    /// 2 - Constructor
    /// 3 - Hit method
    /// 4 - Deal 2 cards to player and computer
    /// 5 - Stand function 
    /// 6 - Update Display
    /// </summary>
    public class Blackjack
    {
        // 1
        Hand PlayersHand;
        Hand ComputersHand;
        Deck GameDeck;
        ( Label, Label) Displays;
        string Feedback = "";
        string Winner = "";
        /// <summary>
        /// Constructor of blackjack class
        /// Creates a deck, hands and shuffles the deck
        /// Deals 2 cards to each player
        /// </summary>
        /// <param name="displays"></param>
        public Blackjack((Label, Label) displays) // 2
        {
            GameDeck = new Deck();
            PlayersHand = new Hand();
            ComputersHand = new Hand();
            GameDeck.ShuffleDeck();
            DealCards();
            Displays = displays;
        }
        /// <summary>
        /// Hit function
        /// Adds a card to the player's hand from the deck
        /// If players hand value > 21 then return true and stand
        /// Else return false
        /// </summary>
        /// <returns></returns>
        public bool Hit() // 3
        {
            PlayersHand.AddCard(GameDeck.Deal());
            if (PlayersHand.Value > 21)
            {
                Stand();
                return true;
            }
            return false;
        }
        /// <summary>
        /// Deal Card Function
        /// For loop to deal 2 cards to each hand
        /// </summary>
        public void DealCards() // 4
        {
            for (int i = 0; i < 2; i++)
            {
                PlayersHand.AddCard(GameDeck.Deal());
                ComputersHand.AddCard(GameDeck.Deal());
            }
        }
        /// <summary>
        /// Stand function
        /// While Computer hand <17 and Less than players hand value deal a card to computer
        /// If statements to find the resulting winner and feedback
        /// Return the values, feedback and winner
        /// </summary>
        /// <returns></returns>
        public (string,string,int,int) Stand() // 5
        {
            while (ComputersHand.Value < 17 && ComputersHand.Value < PlayersHand.Value)
            {
                ComputersHand.AddCard(GameDeck.Deal());
            }
            if (PlayersHand.Value > 21 && ComputersHand.Value > 21){
                Feedback = "Nobody wins!";
                Winner = "Draw";
            }
            else if (PlayersHand.Value > 21)
            {
                Feedback = "Bust!";
                Winner = "Computer";
            }
            else if (ComputersHand.Value > 21)
            {
                Feedback = "Computer went bust!";
                Winner = "Player";
            }
            else if (PlayersHand.Value > ComputersHand.Value)
            {
                Feedback = $"Player wins";
                Winner = "Player";
            }
            else if (PlayersHand.Value < ComputersHand.Value)
            {
                Feedback = "Computer wins";
                Winner = "Computer";
            }
            else if (PlayersHand.Count > ComputersHand.Count)
            {
                Feedback = $"Player wins, equal score but you have more cards";
                Winner = "Player";
            }
            else if (PlayersHand.Count < ComputersHand.Count)
            {
                Feedback = "Computer wins, equal score but you have less cards";
                Winner = "Computer";
            }
            else
            {
                Winner = "Draw";
                Feedback = "Draw";
            }
            UpdateDisplay();
            return (Winner, Feedback,PlayersHand.Value,ComputersHand.Value);
        }
        /// <summary>
        /// Update Display function
        /// Updates the labels content using the hand's cards and values
        /// </summary>
        public void UpdateDisplay() // 6
        {
            Displays.Item1.Text = "Score: "+PlayersHand.Value.ToString();
            Displays.Item2.Text = "Score: " + ComputersHand.Value.ToString();
        }
        public (List<PictureBox>, List<PictureBox>) ReturnPictures()
        {
            return (PlayersHand.CreatePictures(),ComputersHand.CreatePictures());
        }
    }
}
