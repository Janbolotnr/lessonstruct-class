using System;
using System.Collections.Generic;
using System.Text;

namespace lesson170720Value
{
    public struct ValuePoint
    {
        public int X { get; }
        public int Y { get; }

        //non behavior method, pure
        public ValuePoint(int x, int y) => (X, Y) = (x, y);

    }
}
