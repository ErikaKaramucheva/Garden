using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    class Strawberry : EdiblePlant
    {
        public override double Energy()
        {
            return 12 ;
        }

        public override double WaterRequired()
        {
            return 3;
        }
    }
}
