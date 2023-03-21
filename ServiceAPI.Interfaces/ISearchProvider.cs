using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SearchService.API.Interfaces
{
    public interface ISearchProvider<T>
    {
        Task<SearchResults<T>> SearchAsync(string searchText, int skip = 0, int take = 10, string filter = null, string orderBy = null, bool includeTotalCount = true);
    }
}
