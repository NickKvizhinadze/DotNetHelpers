using System;

namespace DotNetHelpers.Extentions
{
    public static class ObjectExtentions
    {
        /// <summary>
        /// Throws Argmunet null exception if object is null
        /// </summary>
        /// <param name="source">Object to check </param>
        public static void ThrowIfNull(this object source)
        {
            if (source == null)
                throw new ArgumentNullException();
        }
    }
}
