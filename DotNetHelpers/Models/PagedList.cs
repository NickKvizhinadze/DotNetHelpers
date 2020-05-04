using System.Collections.Generic;

namespace DotNetHelpers.Models
{
    /// <summary>
    /// Paged list of itmes
    /// </summary>
    /// <typeparam name="T">Type of items</typeparam>
    public class PagedList<T> where T : class
    {
        public PagedList(List<T> items, Paging paging, Sorting sorting)
        {
            Items = items;
            Paging = paging;
            Sorting = sorting;
        }

        /// <summary>
        /// List of items
        /// </summary>
        public List<T> Items { get; private set; }

        /// <summary>
        /// Paging
        /// </summary>
        public Paging Paging { get; private set; }

        /// <summary>
        /// Sorting
        /// </summary>
        public Sorting Sorting { get; private set; }
    }
}
