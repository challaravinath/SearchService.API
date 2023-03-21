using SearchService.API.Interfaces;
using ServiceAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SearchService.API.Services
{
    public class SearchService<T> : ISearchService<T> where T : class
    {
        private readonly ISearchProvider<T> _searchProvider;

      

        public SearchService(ISearchProvider<T> searchProvider)
        {
            _searchProvider = searchProvider;
        }

        public async Task<IEnumerable<T>> SearchAsync(string query, int pageSize, int page, string filter = null, string orderBy = null)
        {
            return (IEnumerable<T>)await _searchProvider.SearchAsync(query, pageSize, page, filter, orderBy);
        }
    }
}
