using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    class Carrot : EdiblePlant
    {
        public override double Energy()
        {
           return 10;
        }

        public override double WaterRequired()
        {
            return 1;
        }
    }
}
