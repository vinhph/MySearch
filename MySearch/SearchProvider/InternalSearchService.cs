using MySearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch.SearchProvider
{
    public class InternalSearchService
    {
        private static SearchProvider _provider;
        public static SearchProvider Provider
        {
            get
            {
                return _provider ?? (_provider = InitializeConfiguredProvider());
            }
            set
            {
                _provider = value;
            }
        }
        private static SearchProvider InitializeConfiguredProvider()
        {
            return new OSGSearchProvider();
        }
        public static ISearchResults Search(string applicationName, ISearchCriteria criteria)
        {
            return Provider.Search(applicationName, criteria);
        }
    }
}
