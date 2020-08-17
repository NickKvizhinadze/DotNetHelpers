namespace DotNetHelpers.Models
{
    /// <summary>
    /// Paging Model
    /// </summary>
    public class Paging
    {
        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Paging()
        {
            CurrentPage = 1;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="page">Current page</param>
        /// <param name="perPage">Items per page</param>
        public Paging(int page, int perPage): this()
        {
            CurrentPage = page;
            PerPage = perPage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page">Current page</param>
        /// <param name="perPage">Items per page</param>
        /// <param name="totalCount">Items total count</param>
        /// <param name="pageCount">page count</param>
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
