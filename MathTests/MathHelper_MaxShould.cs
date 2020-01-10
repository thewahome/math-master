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


    }
}
