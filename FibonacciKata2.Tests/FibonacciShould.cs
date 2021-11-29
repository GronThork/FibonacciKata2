using System;
using Xunit;

namespace FibonacciKata2.Tests
{
    public class FibonacciShould
    {
        [Fact]
        public void ReturnZeroIfTheInputIsZero()
        {
            int actual = Fibonacci.Calculate(0);
            
            Assert.Equal(0, actual);
        }
    }
}