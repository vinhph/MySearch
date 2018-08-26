using MySearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch.SearchProvider
{
    public abstract class SearchProvider
    {
        public abstract ISearchResults Search(string applicationName, ISearchCriteria criteria);
    }
}
