using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName
{
    /// <summary>
    /// Dice class
    /// 1 - Attributes
    /// 2 - Properties
    /// 3 - Methods
    /// 3a - GenerateNumber to roll the dice or create a random number
    /// 3b - ToString override method to create a string output of the dice's output
    /// 4 - Constructors
    /// 4a - Create a dice object with colour Black and number 1
    /// 4b - Create a dice object with a given colour and number
    /// 4c - Create a dice object with a provided colour from call, and call GenerateNumber
    /// </summary>
    internal class DiceOld
    {
        // 1
      
        protected string _Colour;
        protected int _Num;
        // 2
        public string Colour
        {
            get // 2a
            {
                return _Colour;
            }
            set // 2b
            {
                if ((value.Length>0) && (value.Length <= 10)) //2b-1
                {
                    _Colour = value;
                }
                else
                {
                    throw new Exception("Bad Colour : " + value); //2b-2
                }
            }
        } // End of Colour Property

        public virtual int Num // 2c
        {
            get { return _Num; } // Read Only Property
        } // End of Num Property
        // 3
        protected static Random random = new Random();
        public virtual void GenerateNumber() //3a
        {
            _Num = random.Next(1, 6);
        }

        // Override Methods
        public override string ToString() //3c
        {
            return _Colour + " " + _Num;
        }
        // 4
        public DiceOld() //4a
        {
            _Num = 1;
            _Colour = "Black";
        }

        public DiceOld(string inColour, int inNum) //5b
        {
            _Colour = inColour;
            _Num = inNum;
        }

        public DiceOld(string inColour) //4c
        {
            Colour = inColour;
            GenerateNumber();
        }

    } // End of Dice Class
}
