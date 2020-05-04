using System;
using System.Linq;
using System.Linq.Expressions;

namespace DotNetHelpers.Extentions
{
    public static class OrderByExtentions
    {
        /// <summary>
        /// Orders by propertyName
        /// </summary>
        /// <typeparam name="TSource">Type of list to order</typeparam>
        /// <param name="source">List to order</param>
        /// <param name="propertyName">Property name</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> OrderBy<TSource>(this IQueryable<TSource> source, string propertyName)
            => source.OrderBy(GetExpression<TSource>(propertyName));

        /// <summary>
        /// Orders descending by propertyName
        /// </summary>
        /// <typeparam name="TSource">Type of list to order</typeparam>
        /// <param name="source">List to order</param>
        /// <param name="propertyName">Property name</param>
        public static IOrderedQueryable<TSource> OrderByDescending<TSource>(this IQueryable<TSource> source, string propertyName)
            => source.OrderByDescending(GetExpression<TSource>(propertyName));


        #region Private
        //makes expression for specific prop
        private static Expression<Func<TSource, object>> GetExpression<TSource>(string propertyName)
        {
            var param = Expression.Parameter(typeof(TSource), "x");
            Expression body = param;
            foreach (var member in propertyName.Split('.'))
            {
                body = Expression.PropertyOrField(body, member);
            }
            Expression conversion = Expression.Convert(body, typeof(object));
            return Expression.Lambda<Func<TSource, object>>(conversion, param);
        }

        private static bool HasProperty(this Type type, string propertyNames)
        {
            var propArrays = propertyNames.Split('.');

            foreach (var propertyName in propertyNames.Split('.'))
            {
                var prop = type.GetProperty(propertyName);
                if (prop != null)
                    type = prop.PropertyType;
                else
                    return false;
            }

            return true;
        }
        #endregion
    }
}
