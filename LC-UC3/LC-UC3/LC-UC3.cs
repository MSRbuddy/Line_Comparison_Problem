using System;

namespace LC_UC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, x3, x4, y3, y4;
            
            x1 = 2; x2 = 6; y1 = 4; y2 = 7;
            x3 = 1; x4 = 4; y3 = 3; y4 = 6;
            
            var L1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine("Length of Line 1 is: " + L1);

            var L2 = Math.Sqrt((Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)));
            Console.WriteLine("Length of Line 2 is: " + L2);
            
            if (L1.Equals(L2))
                Console.WriteLine("Length of Line 1 is Equals to the Length of Line 2");
            else if (L1.CompareTo(L2) < L2)
                Console.WriteLine("Length of Line 1 is Smaller Than Length of Line 2");
            else
                Console.WriteLine("Length of Line 1 is Greater Than Length of Line 2");

        }
    }
}
