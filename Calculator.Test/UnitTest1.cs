using System;
using Xunit;
using Calculator;

namespace Calculator.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, new long[]{0})]
        [InlineData(1, new long[]{1})]
        [InlineData(2, new long[]{2})]
        [InlineData(66, new long[]{21, 22, 23})]
        [InlineData(1000000, new long[]{199998, 199999, 200000, 200001, 200002})]
        [InlineData(1000000000000, new long[]{199999999998, 199999999999, 200000000000, 200000000001, 200000000002})]
        [InlineData(1000000000000000000, new long[]{199999999999999998, 199999999999999999, 200000000000000000, 200000000000000001, 200000000000000002})]
        public void Test1(long number, long[] expected)
        {
            var cal = new SerialCalculator();
            var result = cal.Calculate(number);
            Assert.Equal(expected, result);
        }
    }
}
