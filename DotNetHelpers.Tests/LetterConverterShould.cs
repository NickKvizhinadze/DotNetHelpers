using Xunit;

namespace DotNetHelpers.Tests
{
    public class LetterConverterShould
    {
        [Fact]
        public void ReturnStringWithLattinLetters()
        {
            var value = "ტესტი";

            var result = LetterConverter.GeoToLatin(value);

            Assert.Equal("testi",result);
        }

        [Fact]
        public void ReturnStringWithGeorgianLetters()
        {
            var value = "test";

            var result = LetterConverter.LatinToGeo(value);

            Assert.Equal("ტესტ", result);
        }

    }
}
