using Xunit;

namespace DotNetHelpers.Tests
{
    public class SlagGeneratorShould
    {
        [Fact]
        public void ReturnUrlFriendlyString()
        {
            var value = "test? /12";

            var result = SlagGenerator.GenerateLink(value);

            Assert.Equal("test-12", result);
        }
    }
}
