using System.Linq;
using System.Collections.Generic;

namespace DotNetHelpers
{
    /// <summary>
    /// Generate Slags
    /// </summary>
    public static class SlagGenerator
    {
        #region Fields
        private static readonly Dictionary<char, char> Dict = new Dictionary<char, char>
        {
            {'ა', 'a'},
            {'ბ', 'b'},
            {'გ', 'g'},
            {'დ', 'd'},
            {'ე', 'e'},
            {'ვ', 'v'},
            {'ზ', 'z'},
            {'თ', 'T'},
            {'ი', 'i'},
            {'კ', 'k'},
            {'ლ', 'l'},
            {'მ', 'm'},
            {'ნ', 'n'},
            {'ო', 'o'},
            {'პ', 'p'},
            {'ჟ', 'J'},
            {'რ', 'r'},
            {'ს', 's'},
            {'ტ', 't'},
            {'უ', 'u'},
            {'ფ', 'f'},
            {'ქ', 'q'},
            {'ღ', 'R'},
            {'ყ', 'y'},
            {'შ', 'S'},
            {'ჩ', 'C'},
            {'ც', 'c'},
            {'ძ', 'Z'},
            {'წ', 'w'},
            {'ჭ', 'W'},
            {'ხ', 'x'},
            {'ჯ', 'j'},
            {'ჰ', 'h'}
        };


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

            return Translate(source.ToLower());
        }
        #endregion

        #region Private Methods
        private static string Translate(string param)
        {
            var result = "";
            foreach (var c in param)
            {
                if (Dict.ContainsKey(c))
                {
                    result += Dict[c];
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

        #endregion
    }
}
