using Xunit;
using DotNetHelpers.Extentions;

namespace DotNetHelpers.Tests
{
    public class StringExtentionsShould
    {
        [Fact]
        public void ReturnTrueWhenStringContainsOnlyEnglishLetters()
        {
            var value = "test";

            var result = value.IsWithEnglishLetters();

            Assert.True(result);
        }

        [Fact]
        public void ReturnFalseWhenStringNotContainsOnlyEnglishLetters()
        {
            var value = "testა";

            var result = value.IsWithEnglishLetters();

            Assert.False(result);
        }

        [Fact]
        public void ReturnTrueWhenStringContainsOnlyGeorgianLetters()
        {
            var value = "ტესტი";

            var result = value.IsWithGeorgianLetters();

            Assert.True(result);
        }

        [Fact]
        public void ReturnFalseWhenStringNotContainsOnlyGeorgianLetters()
        {
            var value = "ტესტიt";

            var result = value.IsWithGeorgianLetters();

            Assert.False(result);
        }
    }
}
