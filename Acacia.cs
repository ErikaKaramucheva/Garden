using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    class Acacia : DecorationTree
    {
        public override double BeautyScore()
        {
            double beautyScore =10 ;
            return beautyScore;
        }

        public override double WaterRequired()
        {
            return 3;
        }
    }
}
