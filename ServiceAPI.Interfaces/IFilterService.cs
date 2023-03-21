using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceAPI.Interfaces
{
    public interface IFilterService<T>
    {
        /// <summary>
        /// FilterByKeyword: Filters the items by a specified keyword.
        /// </summary>
        /// <param name="items">Items to Filter</param>
        /// <param name="keyword">keyword with which to filter</param>
        /// <returns></returns>


        IEnumerable<T> FilterByKeyword(IEnumerable<T> items, string keyword);
        /// <summary>
        /// FilterByCategory: Filters the items by a specified category.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        IEnumerable<T> FilterByCategory(IEnumerable<T> items, string category);
        /// <summary>
        /// FilterByDateRange : Filters the items by a specified date range.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        IEnumerable<T> FilterByDateRange(IEnumerable<T> items, DateTime startDate, DateTime endDate);

    }
}
