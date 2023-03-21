using System;
using System.Collections.Generic;

namespace SearchService.API.Utilities
{
    /// <summary>
    /// PaginatedList is a generic class that represents a paginated subset of a collection of items
    /// </summary>
    /// <typeparam name="T">PaginatedList takes a generic type parameter T,</typeparam>
    public class PaginatedList<T>
    {

        /// <summary>
        /// TotalCount: The total number of items in the original collection.
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// PageNumber: The current page number.
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        ///  PageSize: The size of each page.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Items: The list of items in the current page.
        /// </summary>
        public List<T> Items { get; set; }

        public PaginatedList(int totalCount, int pageNumber, int pageSize, List<T> items)
        {
            TotalCount = totalCount;
            PageNumber = pageNumber;
            PageSize = pageSize;
            Items = items;
        }
    }
}
