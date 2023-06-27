namespace MethodOverloading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int answer1 = Add(29, 55);
            Console.WriteLine(answer1);

            decimal answer2 = Add(23.9m, 65.6m);
            Console.WriteLine(answer2);

            string answer3 = Add(6, 7, false);
            Console.WriteLine(answer3);


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
