using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    abstract class DecorationTree : Tree, IBeauty
    {
        public abstract double BeautyScore();
       
    }
}
