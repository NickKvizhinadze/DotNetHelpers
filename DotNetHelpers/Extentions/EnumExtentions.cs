using System;
using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DotNetHelpers.Extentions
{
    public static class EnumExtentions
    {
        /// <summary>
        /// Converts Enum to collection list
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <returns>List of collection models</returns>
        public static List<KeyValuePair<int, string>> ToCollection<T>(this Type source) where T : Enum =>
            Enum.GetValues(source).Cast<T>()
                .Select(r =>
                    new KeyValuePair<int, string>(Convert.ToInt32(r), r.GetDisplayName())
                    )
                .ToList();

        /// <summary>
        /// Returns display name of enum value
        /// </summary>
        /// <param name="value">Value of Enum</param>
        /// <returns>Name of enum value as string</returns>
        public static string GetDisplayName(this Enum value)
        {
            Type enumType = value.GetType();
            var enumValue = Enum.GetName(enumType, value);
            MemberInfo member = enumType.GetMember(enumValue)[0];

            var attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);

            string outString = value.ToString();

            if (attrs?.Length > 0)
            {
                var attribute = ((DisplayAttribute)attrs[0]);
                outString = attribute.Name;

                if (attribute.ResourceType != null)
                    outString = attribute.GetName();
            }

            return outString;
        }
    }
}
