using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filters.ExceptionFilters
{
    [AttributeUsage(AttributeTargets.Method)]
    public class SkipExceptionFilter : Attribute, IFilterMetadata
    {
    }
}
