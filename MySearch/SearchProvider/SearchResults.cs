using MySearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch.SearchProvider
{
    public class SearchResults : ISearchResults
    {
        public virtual int TotalCount
        {
            get
            {
                if (Documents != null)
                    return Documents.TotalCount;
                return 0;
            }
        }
        public virtual ISearchDocuments Documents { get; set; }
    }
}
