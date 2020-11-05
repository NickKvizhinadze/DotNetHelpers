using System;

namespace DotNetHelpers.Extentions
{
    /// <summary>
    /// Object Extentions
    /// </summary>
    public static class ObjectExtentions
    {
        /// <summary>
        /// Throws Argmunet null exception if object is null
        /// </summary>
        /// <param name="source">Object to check </param>
        /// <param name="parameterName">Name of parameter</param>
        public static void ThrowIfNull(this object source, string parameterName)
        {
            if (source == null)
                throw new ArgumentNullException(parameterName);
        }
    }
}
