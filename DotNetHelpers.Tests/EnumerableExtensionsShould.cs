using Xunit;
using DotNetHelpers.Extentions;

namespace DotNetHelpers.Tests
{
    public class EnumerableExtensionsShould
    {
        [Fact]
        public void ReturnJoinedString()
        {
            var list = new string[] { "String1", "String2", "String3" };
            
            var result = list.Join(", ");

            Assert.Equal("String1, String2, String3", result);
        }
    }
}
