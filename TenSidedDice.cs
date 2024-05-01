using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName
{
    internal class TenSidedDice : DiceOld
    {
        public TenSidedDice(string inColour)
                    : base(inColour) //a
                {
                    GenerateNumber(); //b
                } // end of TenSidedDice Constructor

        public override void GenerateNumber()
        {
            _Num = random.Next(1, 10); //a
        } // end of GenerateNumber method

    } // end of TenSidedDice class
    
}
