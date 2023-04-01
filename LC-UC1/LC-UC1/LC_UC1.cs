using System;

namespace LC_UC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            x1 = 4;
            x2 = 8;
            y1 = 3;
            y2 = 6;
            var distance = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine(distance);
        }
    }
}
