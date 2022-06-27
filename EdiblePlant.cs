using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    abstract class EdiblePlant : Plant, IFood
    {
        public abstract double Energy();
    }
}
