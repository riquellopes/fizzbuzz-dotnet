using System;
using Xunit;

namespace fizzBuzz
{
    public class UnitTest1
    {
        [Fact]
        public void TestFizzBuzzGet0()
        {
            FizzBuzz f = new FizzBuzz
            {
                Numeric = 0
            };

            Assert.Equal("0", f.GetResult());
        }

        [Fact]
        public void TestFizzBuzz1()
        {
            FizzBuzz f = new FizzBuzz
            {
                Numeric = 1
            };

            Assert.Equal("1", f.GetResult());
        }

        [Fact]
        public void TestFizzBuzz3()
        {
            FizzBuzz f = new FizzBuzz
            {
                Numeric = 3
            };

            Assert.Equal("fizz", f.GetResult());
        }

        [Fact]
        public void TestFizzBuzz9()
        {
            FizzBuzz f = new FizzBuzz
            {
                Numeric = 9
            };

            Assert.Equal("fizz", f.GetResult());
        }

        [Fact]
        public void TestFizzBuzz5()
        {
            FizzBuzz f = new FizzBuzz
            {
                Numeric = 5
            };

            Assert.Equal("buzz", f.GetResult());
        }
    }
}
