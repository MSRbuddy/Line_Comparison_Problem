using System;

namespace LC_UC2
{
    internal class program
    { 
        static void idstrt(double a1,double b1,double c1,double a2,double b2,double c2)
        {
            if (((a1 / a2).Equals(b1 / b2)) && ((a1 / a2).Equals(c1 / c2)) && ((b1 / b2).Equals(c1 / c2)))
                Console.WriteLine("The given straight lines are equal");
            else
                Console.WriteLine("The given straight lines are not equal");
        }
        public static void Main(string[] args)
        {
            double a1 = 2, b1 = -4, c1 = 3, a2 = 6, b2 = -12, c2 = 9;
            idstrt(a1, b1, c1, a2, b2, c2);
        }
    }
}
