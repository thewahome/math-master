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
        public void ReturnValueWhenValueOfOperandsIsTheSame(int value1, int value2, int expectedResult)
        {
            var expectedValue = expectedResult;
            var result = _mathHelper.Max(value1,value2);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineDataAttribute(89,88,89)]
        [InlineDataAttribute(57,256,256)]
        [InlineDataAttribute(-9876,-11,-11)]

        public void ReturnMaxOfTwoDifferentValues(int value1, int value2, int expectedResult)
        {
            var expectedValue = expectedResult;
            var result = _mathHelper.Max(value1,value2);
            Assert.Equal(expectedValue, result);
        }


        /// <summary>
        /// Test the fact that Max is commutative - returns the same value regardless of order
        /// Max(A,B) = Max(B,A)
        /// </summary>

        [Fact]
        public void ReturnSameResultIndependentOfOrder() {
            // Arrange
            int x = 9;
            int y = 87;

            // Act
            var result1 = _mathHelper.Max(x,y);
            var result2 =  _mathHelper.Max(y,x);

            // Assert
            Assert.Equal(result1, result2);
        }
    }
}
