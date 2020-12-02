using System;
using System.Collections.Generic;
using System.Text;

namespace lesson170720Value
{
    class ReferencePoint
    {
        private int MinValue = -10;
        private int MaxValue = 10;

        public int X { get; private set; }
        public int Y { get; private set; }

        public ReferencePoint(int x, int y)
        {
            X = x >= MinValue && x <= MaxValue
                ? x
                : 0;

            Y = y >= MinValue && y <= MaxValue
                ? y 
                : 0;
        }

        public void SetX(int x)
        {
            X = x >= MinValue && x <= MaxValue
               ? x
               : 0;
        }

        public void SetY(int y)
        {
            Y = y >= MinValue && y <= MaxValue
                ? y
                : 0;
        }

        public void Reset()
        {
            X = 0;
            Y = 0;
        }
    }
}
