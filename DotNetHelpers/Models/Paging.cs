namespace DotNetHelpers.Models
{
    public class Paging
    {
        #region Constructor
        public Paging()
        {
        }

        public Paging(int page, int perPage)
        {
            CurrentPage = page;
            PerPage = perPage;
        }

        public Paging(int page, int perPage, int totalCount, int pageCount) : this(page, perPage)
        {
            TotalCount = totalCount;
            PageCount = pageCount;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Current Page
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Page Count
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// Total count of items
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Items per page
        /// </summary>
        public int PerPage { get; set; }
        #endregion
    }
}
