namespace FibonacciKata2
{
    public class Fibonacci
    {
        public static int Calculate(int i)
        {
            if (i == 0)
            {
                return 0;
            }
            
            if (i == 1)
            {
                return 1;
            }
            
            return Calculate(i-2) + Calculate(i-1);
        }
    }
}