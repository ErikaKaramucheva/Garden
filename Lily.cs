using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    class Lily : Flowers
    {
        public override double BeautyScore()
        {
            return 7;
        }

        public override double WaterRequired()
        {
            return 2;
        }
    }
}
