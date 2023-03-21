using SearchService.API.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceAPI.Interfaces
{
    public interface IPaginationService<T>
    {
        /// <summary>
        /// PaginateAsync, which takes an IEnumerable<T> 
        /// </summary>
        /// <param name="items">The list of items in the current page.</param>
        /// <param name="pageSize">The size of each page</param>
        /// <param name="pageNumber">The current page number</param>
        /// <returns></returns>
        Task<PaginatedList<T>> PaginateAsync(IEnumerable<T> items, int pageSize, int pageNumber);
    }
}
