using Common.Helpers;
using Xunit;

namespace Common.Tests.Helpers
{
    public class StringHelperTests
    {
        private string alphanumericCharacters = "abcdefghijklmnopqrstuvwxyz1234567890";


        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(25)]
        [InlineData(100)]
        public async Task RandomAlphanumericString_ProperLength(
            int length
            )
        {
            var result = StringHelper.RandomAlphanumericString(length);
            Assert.Equal(length, result.Length);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(25)]
        [InlineData(100)]
        public async Task RandomAlphanumericString_OnlyAlphanumericCharacters(
            int length
            )
        {
            var result = StringHelper.RandomAlphanumericString(length);
            foreach (char character in result)
            {
                Assert.True(alphanumericCharacters.Contains(character));
            }
        }
    }
}
