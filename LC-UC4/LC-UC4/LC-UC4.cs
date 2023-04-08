namespace LC_UC4
{
    internal class Program
    {
        public static void CompareLines()
        {
            double x1, x2, x3, x4, y1, y2, y3, y4;
            x1 = 1; x2 = 2; y1 = 3; y2 = 4;

            var L1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine("Length of Line 1 is: " + L1);

            x3 = 5; x4 = 6; y3 = 7; y4 = 8;
            var L2 = Math.Sqrt((Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)));
            Console.WriteLine("Length of Line 2 is: " + L2);

            if (L1.CompareTo(L2) == 0)
            {
                Console.WriteLine("Length of Line 1 is Equals to Length of Line 2");
            }
            if (L1.CompareTo(L2) != 0)

            {
                Console.WriteLine("Length of Line 1 is Not Equals to Length of Line 2");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Line-Comparison Problem UseCase-4!");
            CompareLines();
        }
    }
}