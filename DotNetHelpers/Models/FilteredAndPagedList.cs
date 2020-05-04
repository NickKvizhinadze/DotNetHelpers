using System.Collections.Generic;

namespace DotNetHelpers.Models
{
    /// <summary>
    /// Paged list of filtered itmes
    /// </summary>
    /// <typeparam name="T">Type of items</typeparam>
    /// <typeparam name="TFilter">Type of items filter</typeparam>
    public class FilteredAndPagedList<T, TFilter> : PagedList<T> where T : class where TFilter : class
    {
        public FilteredAndPagedList(List<T> items, TFilter filter, Paging paging, Sorting sorting) : base(items, paging, sorting)
        {
            Filter = filter;
        }

        public TFilter Filter { get; private set; }
    }
}
