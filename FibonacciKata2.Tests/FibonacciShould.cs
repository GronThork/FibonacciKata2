using System;
using Xunit;

namespace FibonacciKata2.Tests
{
    public class FibonacciShould
    {
        [Fact]
        public void ReturnZeroIfTheInputIsZero()
        {
            var actual = Fibonacci.Calculate(0);
            
            Assert.Equal(0, actual);
        }
        
        [Fact]
        public void ReturnOneIfTheInputIsOne()
        {
            var actual = Fibonacci.Calculate(1);
            
            Assert.Equal(1, actual);
        }

    }
}