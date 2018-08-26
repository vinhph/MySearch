using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySearch.Models;

namespace MySearch.SearchProvider
{
    public class OSGSearchProvider : SearchProvider
    {
        public override ISearchResults Search(string applicationName, ISearchCriteria criteria)
        {
            var OSGSearchResults = new OSGSearchResult("ResultDataExample");
            return (ISearchResults)OSGSearchResults;
        }
    }
}
