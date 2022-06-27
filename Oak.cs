using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    class Oak : DecorationTree
    {
        public override double BeautyScore()
        {
            return 5;
        }

        public override double WaterRequired()
        {
            return 11;
        }
    }
}
