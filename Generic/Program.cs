namespace Generic
{
    class Helper<T>// where T : class
    {
        public static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }

    internal class Program
    {
        

        //static void Swap(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //}

        //static void Swap(ref string x, ref string y)
        //{
        //    string temp = x;
        //    x = y;
        //    y = temp;
        //}

        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Console.WriteLine("Before Swapping");
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"y: {y}");

            Helper<int>.Swap(ref x, ref y);

            Console.WriteLine("After Swapping");
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"y: {y}");

            double d1 = 10.5;
            double d2 = 20.3;

            Console.WriteLine("\nBefore Swapping");
            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d2: {d2}");

            Helper<double>.Swap(ref d1, ref d2);

            Console.WriteLine("After Swapping");
            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d2: {d2}");

            string s1 = "Mohamed";
            string s2 = "Ali";

            Console.WriteLine("\nBefore Swapping");
            Console.WriteLine($"s1: {s1}");
            Console.WriteLine($"s2: {s2}");

            Helper<string>.Swap(ref s1, ref s2);

            Console.WriteLine("After Swapping");
            Console.WriteLine($"s1: {s1}");
            Console.WriteLine($"s2: {s2}");
        }
    }
}
