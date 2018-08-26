using MySearch.SearchProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch.Models
{
    public class SearchFacade
    {
        private bool _initialized;
        private SearchManager _searchManager;
        public virtual ISearchResults Search(CatalogEntrySearchCriteria criteria)
        {
            Initialize();
            return _searchManager.Search(criteria);
        }
        private void Initialize()
        {
            if (_initialized)
            {
                return;
            }
            _searchManager = new SearchManager("OSG.Search.Application");
            _initialized = true;
        }
    }
}
