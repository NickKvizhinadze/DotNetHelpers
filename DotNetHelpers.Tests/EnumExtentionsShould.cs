using Xunit;
using DotNetHelpers.Enums;
using DotNetHelpers.Extentions;
using System.Collections.Generic;

namespace DotNetHelpers.Tests
{
    public class EnumExtentionsShould
    {
        [Fact]
        public void ReturnKeyValuePairOfEnumValues()
        {
            var result = typeof(SortDirection).ToCollection<SortDirection>();

            Assert.Equal(
                new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Ascending"),
                new KeyValuePair<int, string>(2, "Descending"),
                },
                result);
        }

        [Fact]
        public void ReturnStringNameOfEnumValue()
        {
            var result = SortDirection.Ascending.ToString();

            Assert.Equal("Ascending", result);
        }
    }
}
