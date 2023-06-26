namespace MethodOverloading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 29;
            int b = 55;
                int answer = Add(a, b);
            decimal d = 23.9m;
            decimal e = 60.5m;
                var decimalAnswer = Add(d, e);

            var lastSum = Add(0, 0, true);
            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(lastSum.ToString());


        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal d, decimal e)
        {
            return d + e;
        }
        public static string Add(int a, int b, bool c)
        {
            int sum = a + b;

            if (c == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (c == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (c == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
    }

}
