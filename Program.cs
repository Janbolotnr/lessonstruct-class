using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace lesson170720Value
{
    class Program
    {
        static void Main(string[] args)
        {
            ValuePoint point1 = new ValuePoint(2, -1);
            Console.WriteLine(point1.X + " " + point1.Y); //2, -1

            point1 = new ValuePoint(0, 0);
            Console.WriteLine(point1.X + " " + point1.Y); // 0, 0

            ReferencePoint point2 = new ReferencePoint(4, 3);
            Console.WriteLine(point2.X + " " + point2.Y);//4, 3

            point2.Reset();
            point2.SetX(2);
            point2.SetY(42);

            Console.WriteLine(point2.X + " " + point2.Y);
        }
    }
}
