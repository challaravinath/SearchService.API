using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SearchService.API.Interfaces
{
    public interface ISearchService<T> where T: class
    {
        Task<IEnumerable<T>> SearchAsync(string query, int pageSize, int page, string filter = null, string orderBy = null);
    }
}
