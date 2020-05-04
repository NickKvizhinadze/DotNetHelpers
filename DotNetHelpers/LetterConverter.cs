using System.Collections.Generic;
using System.Linq;

namespace DotNetHelpers
{
    public static class LetterConverter
    {
        #region Fields
        private static readonly Dictionary<char, char> GeorgianLettersToLatinMap = new Dictionary<char, char>
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

        private static readonly Dictionary<char, char> LatinLettersToGeorgianMap = new Dictionary<char, char>
        {
            {'a', 'ა'},
            {'b', 'ბ'},
            {'g', 'გ'},
            {'d', 'დ'},
            {'e', 'ე'},
            {'v', 'ვ'},
            {'z', 'ზ'},
            {'T', 'თ'},
            {'i', 'ი'},
            {'k', 'კ'},
            {'l', 'ლ'},
            {'m', 'მ'},
            {'n', 'ნ'},
            {'o', 'ო'},
            {'p', 'პ'},
            {'J', 'ჟ'},
            {'r', 'რ'},
            {'s', 'ს'},
            {'t', 'ტ'},
            {'u', 'უ'},
            {'f', 'ფ'},
            {'q', 'ქ'},
            {'R', 'ღ'},
            {'y', 'ყ'},
            {'S', 'შ'},
            {'C', 'ჩ'},
            {'c', 'ც'},
            {'Z', 'ძ'},
            {'w', 'წ'},
            {'W', 'ჭ'},
            {'x', 'ხ'},
            {'j', 'ჯ'},
            {'h', 'ჰ'}
        };
        #endregion

        #region Methods
        /// <summary>
        /// Convert georgian string to latin letters
        /// </summary>
        /// <param name="source">String with georgian letters</param>
        /// <returns>String with latin letters</returns>
        public static string GeoToLatin(string source)
        {
            var result = "";
            foreach (var c in source)
            {
                if (GeorgianLettersToLatinMap.ContainsKey(c))
                    result += GeorgianLettersToLatinMap[c];
                else
                    result += c;
            }

            return result;
        }

        /// <summary>
        /// Convert latin string to georgian letters
        /// </summary>
        /// <param name="source">String with georgian letters</param>
        /// <returns>String with latin letters</returns>
        public static string LatinToGeo(string source)
        {
            var result = "";
            foreach (var c in source)
            {
                if (LatinLettersToGeorgianMap.ContainsKey(c))
                    result += LatinLettersToGeorgianMap[c];
                else
                    result += c;
            }

            return result;
        }
        #endregion
    }
}
