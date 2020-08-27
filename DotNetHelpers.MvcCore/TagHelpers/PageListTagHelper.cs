using System.Linq;
using System.Collections.Generic;
using DotNetHelpers.MvcCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DotNetHelpers.MvcCore.TagHelpers
{
    public class PageListTagHelper : TagHelper
    {
        #region Fields
        private int _startPage;
        private int _pageCount;
        private bool _dotsEntered;
        private Dictionary<string, string> _classes = new Dictionary<string, string>()
        {
            {"ul", "pagination" },
            {"firstLi", "page-item" },
            {"prevLi", "page-item" },
            {"nextLi", "page-item" },
            {"lastLi", "page-item" },
            {"firstA", "page-link" },
            {"prevA", "page-link" },
            {"nextA", "page-link" },
            {"lastA", "page-link" },
            {"li", "page-item" },
            {"a", "page-link" }
        };
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
        public bool ShowFirstAndLast { get; set; } = true;
        public Dictionary<string, string> Classes { get; set; } = new Dictionary<string, string>();
        public string FirstElementString { get; set; } = "<i class=\"fas fa-fast-backward\"></i>";
        public string PrevElementString { get; set; } = "<i class=\"fas fa-step-backward\"></i>";
        public string NextElementString { get; set; } = "<i class=\"fas fa-step-forward\"></i>";
        public string LastElementString { get; set; } = "<i class=\"fas fa-fast-forward\"></i>";
        #endregion

        #region Override Methods
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            GenerateVariables();
            output.TagName = "ul";
            output.Attributes.Add("class", Classes["ul"]);

            var first = CreateLiElement(1, PrevElementString, CurrentPage == 1, false, Classes["firstLi"], Classes["firstA"]);
            var previous = CreateLiElement(CurrentPage - 1, PrevElementString, CurrentPage == 1, false, Classes["prevLi"], Classes["prevA"]);
            var next = CreateLiElement(CurrentPage + 1, NextElementString, CurrentPage == LastPage, false, Classes["nextLi"], Classes["nextA"]);
            var last = CreateLiElement(LastPage, LastElementString, CurrentPage == LastPage, false, Classes["lastLi"], Classes["lastA"]);

            if (ShowFirstAndLast)
                output.Content.AppendHtml(first);
            output.Content.AppendHtml(previous);

            foreach (var i in Enumerable.Range(_startPage, _pageCount))
            {
                if (i - _startPage > 5 && !(LastPage - i < 5))
                {
                    if (i - _startPage > 6 && !_dotsEntered)
                    {
                        _dotsEntered = true;
                        var li = CreateLiElement(0, "...", true, false, Classes["li"], Classes["a"]);
                        output.Content.AppendHtml(li);
                    }
                }
                else
                {
                    var li = CreateLiElement(i, i.ToString(), false, CurrentPage == i, Classes["li"], Classes["a"]);
                    output.Content.AppendHtml(li);
                }
            }

            output.Content.AppendHtml(next);
            if (ShowFirstAndLast)
                output.Content.AppendHtml(last);
        }
        #endregion

        #region Private Methods
        private TagBuilder CreateLiElement(int page, string anchoreText, bool isDisabled, bool isActive, string liClass, string aClass)
        {
            var result = new TagBuilder("li");
            result.AddCssClass(liClass);
            if (isDisabled)
                result.AddCssClass("disabled");

            if (isActive)
                result.AddCssClass("active");

            var a = CreateAnchorElement(page, anchoreText, aClass);

            result.InnerHtml.AppendHtml(a);
            return result;
        }

        private TagBuilder CreateAnchorElement(int page, string text, string aClass)
        {
            var a = new TagBuilder("a");

            a.AddCssClass(aClass);

            var url = BaseUrl + (BaseUrl.Contains("?") ? $"&" : "?") + $"page={page}";
            a.Attributes.Add("href", url);
            a.Attributes.Add("data-page", page.ToString());
            a.InnerHtml.AppendHtml(text);

            return a;
        }

        private void GenerateVariables()
        {
            foreach (var item in _classes)
                if (!Classes.ContainsKey(item.Key))
                    Classes.Add(item.Key, item.Value);

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