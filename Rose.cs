using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    class Rose : Flowers
    {
        public override double BeautyScore()
        {
            return 15;
        }

        public override double WaterRequired()
        {
            return 5;
        }
    }
}
