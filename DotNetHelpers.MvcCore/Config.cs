namespace DotNetHelpers.MvcCore
{
    public static class Config
    {
        #region Constructors
        static Config()
        {
            NumberOfShownPages = 10;
        }
        #endregion

        #region Properties
        public static int NumberOfShownPages { get; private set; } = 10;
        #endregion

        #region Methods
        public static void Init(int numberOfShownPages)
        {
            NumberOfShownPages = numberOfShownPages;
        }
        #endregion
    }
}
