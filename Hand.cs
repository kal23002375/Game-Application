using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName
{
    /// <summary>
    /// Hand class
    /// 1 - Attributes
    /// 2 - Constructor, creates list and sets score to 0
    /// 3 - Returns hand score
    /// 4 - Count list length
    /// 5 - Function for adding card to hand, updates score
    /// 6 - Remove Card from Hand
    /// 7 - Returns face of the top card
    /// 8 - Returns the hand as a string
    /// 9 - Clears the hand
    /// </summary>
    internal class Hand
    {
        // 1
        private List<PlayingCard> _Cards;
        private int score;
        int aces = 0;
        public Hand() // 2
        {
            _Cards = new List<PlayingCard>();
            score = 0;
        } // End of hand constructor
        /// <summary>
        /// Returns the score of the hand
        /// </summary>
        public int Value // 3
        {
            get { return score; }
        }
        /// <summary>
        /// Returns the amount of cards in the hand
        /// </summary>
        public int Count // 4
        {
            get { return _Cards.Count; }
        }
        /// <summary>
        /// Adds a card to deck, updates the Hand's score
        /// If statements for when card face is jack, queen, king
        /// If statements to handle Aces
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(PlayingCard card) // 5
        {
            if (card.face == "Ace" && score <= 10)
            {
                score += 11;
                card.Value(11);
                aces++;
            }
            else if (card.Value() > 10)
            {
                score += 10;
                card.Value(10);
            }
            else
            {
                score += card.Value();
            }
            _Cards.Add(card);
            while (score > 21 && aces > 0)
            {
                foreach (PlayingCard c in _Cards)
                {
                    if (c.face == "Ace" && c.Value() != 1)
                    {
                        aces--;
                        score -= 10;
                        int index = _Cards.IndexOf(c);
                        c.Value(1);
                        _Cards[index] = c;
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// Returns the hand's cards as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString() // 8
        {
            string returnString = "";
            foreach (var card in _Cards)
            {
                returnString += card.ToString() + "\n";
            }
            return returnString;
        }
        /// <summary>
        /// Clears the PlayingCard list
        /// </summary>
        public void Clear() // 9
        {
            _Cards.Clear();
        }
        public List<PlayingCard> ReturnHand()
        {
            return _Cards;
        }
        public List<PictureBox> CreatePictures()
        {
            List<PictureBox> list = new List<PictureBox>();
            foreach (var card in _Cards)
            {
                PictureBox picture = new PictureBox();
                picture.Size = new Size(75, 150);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Image = (Image)Properties.Resources.ResourceManager.GetObject(card.face.ToLower() + card.suit.ToString().ToLower());
                picture.Location = new Point((_Cards.IndexOf(card)*80+5),5);
                picture.BackColor= Color.White;
                picture.BringToFront();
                list.Add(picture);
            }
            return list;
        }
    }
}
