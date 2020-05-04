using System.Text.RegularExpressions;

namespace DotNetHelpers.Extentions
{
    public static class StringExtentions
    {
        /// <summary>
        /// Checks if string contains only english letters
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsWithEnglishLetters(this string value)
        {
            Regex regexObj = new Regex("^[A-Za-z]+$");
            return regexObj.IsMatch(value);
        }

        /// <summary>
        /// Checks if string contains only georgian letters
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsWithGeorgianLetters(this string value)
        {
            Regex regexObj = new Regex("^[ა-ჰ]+$");
            return regexObj.IsMatch(value);
        }

    }
}
