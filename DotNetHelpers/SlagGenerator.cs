using System.Linq;
using System.Collections.Generic;

namespace DotNetHelpers
{
    public static class SlagGenerator
    {
        #region Fields
        private static readonly List<string> PreventedChars = new List<string>
        {
            "#",
            "$",
            "&",
            "%",
            "@",
            "`",
            "/",
            ":",
            ";",
            "<",
            "=",
            ">",
            "?",
            "[",
            "\\",
            "]",
            "^",
            "{",
            "|",
            "}",
            "~",
            "“",
            "‘",
            "+",
            ","
        };

        #endregion

        #region Methods
        /// <summary>
        /// Generate string for url
        /// </summary>
        /// <param name="source">Source</param>
        /// <returns>Url friendly string</returns>
        public static string GenerateLink(this string source)
        {
            source = PreventedChars.Aggregate(source, (current, c) => current.Replace(c, ""));
            source = source.Replace(' ', '-');

            return source.ToLower();
        }
        #endregion
    }
}
