using MySearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch.SearchProvider
{
    public class SearchManager
    {
        private readonly string _applicationName;
        public SearchManager(string applicationName)
        {
            _applicationName = applicationName;
        }
        public ISearchResults Search(ISearchCriteria criteria)
        {
            return InternalSearchService.Search(this._applicationName, criteria);
        }
    }
}
