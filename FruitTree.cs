using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    abstract class FruitTree : Tree, IFood
    {
        public abstract double Energy();
        
    }
}
