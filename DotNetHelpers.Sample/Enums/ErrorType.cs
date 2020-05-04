using System.ComponentModel.DataAnnotations;
using DotNetHelpers.Sample.Resources;

namespace DotNetHelpers.Sample.Enums
{
    public enum ErrorType
    {
        [Display(ResourceType = typeof(Common), Name = nameof(Common.Internal))]
        Internal,
        [Display(ResourceType = typeof(Common), Name = nameof(Common.BadRequest))]
        BadRequest
    }
}
