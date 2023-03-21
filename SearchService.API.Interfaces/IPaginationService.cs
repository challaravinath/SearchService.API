using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SearchService.API.Interfaces
{
    public interface IPaginationService
    {
        Task<PaginatedList<T>> PaginateAsync(IEnumerable<T> items, int pageSize, int pageNumber);
    }
}
