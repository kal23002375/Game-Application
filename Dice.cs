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
    /// 4 - Constuctor
    /// </summary>
    internal class Dice
    {
        // 1
        protected int _Num;
        private int Sides;
        protected static Random random = new Random();
        // 2
        /// <summary>
        /// Num property
        /// Returns the number on the dice
        /// </summary>
        public virtual int Num 
        {
            get { return _Num; } // Read Only Property
        } // End of Num Property

        // 3
        /// <summary>
        /// Generate number rolls the dice
        /// a - Set _Num to a random number between 1 and sides value
        /// </summary>
        public virtual void GenerateNumber()
        {
            _Num = random.Next(1, Sides); //a
        }

        // 4
        /// <summary>
        /// Dice constructor
        /// a - Set sides to the argument passed in
        /// b - Run Generate Number method
        /// </summary>
        /// <param name="sides"></param>
        public Dice(int sides) //8
        {
            Sides = sides; //a
            GenerateNumber(); //b
        }

    } // End of Dice Class
}
