using System;
using Xunit;
using MathLibrary;

namespace MathTests
{
    public class MathHelper_MaxShould
    {
        private readonly MathHelper _mathHelper;
        public MathHelper_MaxShould()
        {
            _mathHelper = new MathHelper();
        }
        [Fact]
        public void Return0GivenValuesOf0()
        {
            var expectedValue = 0;
            var result = _mathHelper.Max(0,0);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineDataAttribute(89,89,89)]
        [InlineDataAttribute(-40789,-40789,-40789)]
        [InlineDataAttribute(275,275,275)]
        [InlineDataAttribute(0,0,0)]
        public void ReturnValueWhenValueOfOperandsIsTheSame(int value1, int value2, int expectedResult)
        {
            var expectedValue = expectedResult;
            var result = _mathHelper.Max(value1,value2);
            Assert.Equal(expectedValue, result);
        }
    }
}
