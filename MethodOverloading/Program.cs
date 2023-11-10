namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("part 1");
            Console.WriteLine("Add(56, 44)");
            Console.WriteLine(Add(56, 44));
            Console.WriteLine("");
            Console.WriteLine("part 2 add decimals");
            Console.WriteLine("Add(.25m, .5m)");
            Console.WriteLine(Add(.25m, .5m));
            Console.WriteLine("");
            Console.WriteLine("part 3 dolla dolla");
            Console.WriteLine("Add(56, 44, true)");
            Console.WriteLine(Add(56, 44, true));
            Console.WriteLine("Add(56, 44, false)");
            Console.WriteLine(Add(56, 44, false));
            Console.WriteLine("Add(1, 0, true)");
            Console.WriteLine(Add(1, 0, true));
            
        }

        public static int Add(int int1, int int2) => int1 + int2;

        public static decimal Add(decimal dec1, decimal dec2) => dec1 + dec2;

        public static string Add(int int1, int int2, bool addDollarStr)
        {
            if (int1 + int2 == 1)
            {
                return (addDollarStr) ? "1 dollar" : "1";
            }
            else
            {
                return (addDollarStr) ? Convert.ToString(int2 + int1) + " dollars" : Convert.ToString(int2 + int1);
            }
            
        }
            
    }
}
