using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    abstract class Flowers : Plant, IBeauty
    {
        public abstract double BeautyScore();
    }
}
