using System.Collections.Generic;

namespace DotNetHelpers.Extentions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Converts list|array to string with separator
        /// </summary>
        /// <param name="source">List/Array to convert</param>
        /// <param name="separator">string to use to separate List/Array items</param>
        /// <returns></returns>
        public static string Join<T>(this IEnumerable<T> source, string separator)
        {
            return string.Join(separator, source);
        }
    }
}
