using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DotNetHelpers.MvcCore.TagHelpers
{
    public class PageListTagHelper : TagHelper
    {
        #region Fields
        private int _startPage;
        private int _pageCount;
        #endregion

        #region Constructors
        public PageListTagHelper()
        {
        }
        #endregion

        #region Properties
        public int LastPage { get; set; }
        public int CurrentPage { get; set; }
        public string BaseUrl { get; set; } = string.Empty;
        #endregion

        #region Override Methods
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            GenerateVariables();
            output.TagName = "ul";
            output.Attributes.Add("class", "pagination");

            var first = CreateLiElement(1, "<i class=\"fas fa-fast-backward\"></i>", CurrentPage == 1, false, true);
            var previous = CreateLiElement(CurrentPage - 1, "<i class=\"fas fa-step-backward\"></i>", CurrentPage == 1, false, true);
            var next = CreateLiElement(CurrentPage + 1, "<i class=\"fas fa-step-forward\"></i>", CurrentPage == LastPage, false, true);
            var last = CreateLiElement(LastPage, "<i class=\"fas fa-fast-forward\"></i>", CurrentPage == LastPage, false, true);

            output.Content.AppendHtml(first);
            output.Content.AppendHtml(previous);

            foreach (var i in Enumerable.Range(_startPage, _pageCount))
            {
                if (i - _startPage > 5 && !(LastPage - i < 5))
                {
                    if (i - _startPage > 6)
                    {
                        var li = CreateLiElement(0, "...", true, false, false);
                        output.Content.AppendHtml(li);
                    }
                }
                else
                {
                    var li = CreateLiElement(i, i.ToString(), false, CurrentPage == i, true);
                    output.Content.AppendHtml(li);
                }
            }

            output.Content.AppendHtml(next);
            output.Content.AppendHtml(last);
        }
        #endregion

        #region Private Methods
        private TagBuilder CreateLiElement(int page, string anchoreText, bool isDisabled, bool isActive, bool useClassForAnchor)
        {
            var result = new TagBuilder("li");
            result.AddCssClass("page-item");
            if (isDisabled)
                result.AddCssClass("disabled");

            if (isActive)
                result.AddCssClass("active");

            var a = CreateAnchorElement(page, anchoreText, useClassForAnchor);

            result.InnerHtml.AppendHtml(a);
            return result;
        }

        private TagBuilder CreateAnchorElement(int page, string text, bool useClass = true)
        {
            var a = new TagBuilder("a");

            if (useClass)
                a.AddCssClass("page-link");

            var url = BaseUrl + (BaseUrl.Contains("?") ? $"&" : "?") + $"page={page}";
            a.Attributes.Add("href", url);
            a.Attributes.Add("data-page", page.ToString());
            a.InnerHtml.AppendHtml(text);

            return a;
        }

        private void GenerateVariables()
        {
            var numberOfShownPages = Config.NumberOfShownPages;
            if (LastPage < numberOfShownPages)
            {
                _startPage = 1;
                _pageCount = LastPage;
            }
            else if (LastPage - CurrentPage >= numberOfShownPages)
            {
                _startPage = CurrentPage;
                _pageCount = LastPage - CurrentPage + 1;
            }
            else
            {
                _startPage = LastPage - (numberOfShownPages - 1);
                _pageCount = numberOfShownPages;
            }
        }
        #endregion
    }
}
