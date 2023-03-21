using System.Collections.Generic;
using System;

namespace SearchService.API.Interfaces
{
    public class SearchResults<T>
    {
        public List<T> Results { get; set; }
        public long TotalCount { get; set; }
        public TimeSpan ElapsedTime { get; set; }
    }
}