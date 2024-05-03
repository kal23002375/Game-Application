using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName
{
    public enum Suits { // Enum containing suits
        Clubs, Spades, Diamonds, Hearts
    }
    public enum Faces { // Enum containing faces and their values
        Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8,Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13,
    }
    /// <summary>
    /// Playing cards data structure, holds its face and suit
    /// </summary>
    public struct PlayingCard { // Data structure that defines a playing card. 
        public Suits suit;
        public string face;
        public int value;
        public PlayingCard(Suits suit, string face)
        {
            this.suit = suit;
            this.face = face;
            this.value = (int)Enum.Parse(typeof(Faces), face);
        }
        public override string ToString()
        {
            return $"{suit} : {face} : {this.value}";
        }
        public int Value()
        {
            return value;
        }
        public void Value(int num)
        {
            this.value = num;
        }
    }
    /// <summary>
    /// Deck class
    /// 1 - Attributes
    /// 2 - Constructor
    /// 3 - Create deck method to go through each suit and face in their respective Enum and create cards
    /// 4 - Returns the entire deck as a string
    /// 5 - ShuffleDeck randomises the order of all the cards
    /// 6 - DealCard removes the card from the top of the deck outputs it
    /// 7 - Adds the card inputted to the deck
    /// </summary>
    public class Deck // 
    {
        // 1
        List<PlayingCard> _Cards = new List<PlayingCard>(); 
        Random rand = new Random();
        public Deck() //2
        {
            createDeck();
        }
        /// <summary>
        /// Iterates through each face and suit to create a set of cards in a deck
        /// a - Iterate through each suit
        /// b - Iterate through each face
        /// c - Add the created card to the deck
        /// </summary>
        private void createDeck() // 3
        {
            foreach (var suit in Enum.GetValues<Suits>()) // a
            {
                foreach (var face in Enum.GetNames<Faces>()) // b
                {
                    _Cards.Add(new PlayingCard(suit, face)); // c
                }
            }
        }
        /// <summary>
        /// Returns the deck as a string
        /// </summary>
        /// <returns>String</returns>
        public string ReturnDeck() // 4
        {
            string feedback = "";
            feedback += _Cards.Count + "\n";
            foreach (PlayingCard card in _Cards)
            {
                feedback += card.face + " : " + card.suit + " " + (int)Enum.Parse(typeof(Faces), card.face) + "\n";
            }
            return feedback;
        } // End ReturnDeck
        /// <summary>
        /// Shuffles the cards in the existing deck
        /// a - Create a temporary list of PlayingCard
        /// b - While loop that repeats until initial deck is empty
        /// c - Create a random number between 0 and count of cards
        /// d - Adds the card in index of random number to temp list
        /// e - Removes card from first list
        /// </summary>
        public void ShuffleDeck() // 5
        {
            List<PlayingCard> shuffledDeck = new List<PlayingCard>(); //a
            while (_Cards.Count > 0) // b
            {
                int selected = rand.Next(_Cards.Count); // c
                shuffledDeck.Add(_Cards[selected]); // d
                _Cards.RemoveAt(selected); // e
            }
            _Cards = shuffledDeck; // f
        } // End ShuffleDeck
        /// <summary>
        /// Deals a card from the front of the list
        /// a - Select first card
        /// b - Remove it from the deck
        /// c - Return the card
        /// </summary>
        /// <returns></returns>
        public PlayingCard Deal() // 6
        {
            PlayingCard Card = _Cards[0]; // a
            _Cards.RemoveAt(0); // b
            return Card; // c
        } // End DealCard
        /// <summary>
        /// Places a card back into the deck
        /// </summary>
        /// <param name="card"></param>
        public void PlaceIntoDeck(PlayingCard card) // 7
        {
            _Cards.Add(card);
        } // End PlaceIntoDeck
    } // End of Deck class
    
    
}
