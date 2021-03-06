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

        [Fact]
        public void ReturnOneIfTheInputIsTwo()
        {
            var actual = Fibonacci.Calculate(2);
            
            Assert.Equal(1, actual);
        }

        [Fact]
        public void ReturnTwoIfTheInputIsThree()
        {
            var actual = Fibonacci.Calculate(3);
            
            Assert.Equal(2, actual);
        }

        [Fact]
        public void ReturnThreeIfTheInputIsFour()
        {
            var actual = Fibonacci.Calculate(4);
            
            Assert.Equal(3, actual);
        }

        [Fact]
        public void ReturnFiveIfTheInputIsFive()
        {
            var actual = Fibonacci.Calculate(5);
            
            Assert.Equal(5, actual);
        }

    }
}