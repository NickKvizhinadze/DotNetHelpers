using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using DotNetHelpers.Enums;
using DotNetHelpers.Models;

namespace DotNetHelpers.MvcCore.TagHelpers
{
    public class GridHeaderTagHelper : TagHelper
    {
        #region Properties
        public Sorting Sorting { get; set; }
        public string PropertyName { get; set; }
        #endregion

        #region Override Methods
        public async override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "th";
            output.Attributes.SetAttribute("data-direction", GetDirection());
            output.Attributes.SetAttribute("data-field", PropertyName);

            if (Sorting?.PropertyName == PropertyName)
            {
                var content = await output.GetChildContentAsync();
                var oldConcent = content.GetContent();
                output.Content.SetHtmlContent(oldConcent + " " + GetArrow());
            }
        }
        #endregion

        #region Private Methods
        private int GetDirection()
        {
            if (PropertyName == Sorting?.PropertyName)
            {
                if (Sorting.Direction == SortDirection.Descending)
                    return (int)SortDirection.Ascending;
            }

            return (int)SortDirection.Descending;
        }

        private string GetArrow()
        {
            if (Sorting.Direction == SortDirection.Descending)
                return "<i class=\"fas fa-arrow-down\"></i>";
            else
                return "<i class=\"fas fa-arrow-up\"></i>";

        }
        #endregion
    }
}
