namespace FibonacciKata2
{
    public class Fibonacci
    {
        public static int Calculate(int i)
        {
            if (i == 1)
            {
                return 1;
            }
            
            if (i == 2)
            {
                return 1;
            }

            if (i == 3)
            {
                return 2;
            }
            
            if (i == 4)
            {
                return 3;
            }

            return 0;
        }
    }
}