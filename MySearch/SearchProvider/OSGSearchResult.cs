using MySearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch.SearchProvider
{
    public class OSGSearchResult : SearchResults
    {
        public OSGSearchResult(string initData)
        {
            PopulateDocuments(initData);
        }

        private void PopulateDocuments(string initData)
        {
            var searchDocuments = new SearchDocuments();
            foreach (var t in initData)
            {
                var searchDocument = new SearchDocument() { Value = t.ToString() };
                searchDocuments.Add((ISearchDocument)searchDocument);
            }

            searchDocuments.TotalCount = initData.Length;
            this.Documents = (ISearchDocuments)searchDocuments;
        }
    }
}
