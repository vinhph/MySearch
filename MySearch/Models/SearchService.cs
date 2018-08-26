using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch.Models
{
    public class SearchService : ISearchService
    {
        private readonly SearchFacade _search;
        public SearchService(SearchFacade search)
        {
            _search = search;
        }
        public CustomSearchResult Search(IContent currentContent, FilterOptionViewModel filterOptions)
        {
            var criteria = CreateFullSearchCriteria(currentContent, filterOptions);
            return Search(criteria, currentContent);
        }
        private CustomSearchResult Search(CatalogEntrySearchCriteria criteria, IContent currentContent)
        {
            ISearchResults searchResult = _search.Search(criteria);
            return new CustomSearchResult
            {
                ProductViewModels = CreateProductViewModels(searchResult)
            };
        }
        private IEnumerable<ProductTileViewModel> CreateProductViewModels(ISearchResults searchResult)
        {
            return searchResult.Documents.Select(x => new ProductTileViewModel() {
                Title = "Title " + ((ISearchDocument)x).Value,
                Content = "Content " + ((ISearchDocument)x).Value
            });
        }
        private CatalogEntrySearchCriteria CreateFullSearchCriteria(IContent currentContent, FilterOptionViewModel filterOptions)
        {
            CatalogEntrySearchCriteria criteria = new CatalogEntrySearchCriteria();
            
            var nodeContent = currentContent as NodeContent;
            if (nodeContent != null)
            {
                criteria.CatalogName = nodeContent.Code;
            }

            return criteria;
        }
    }
}
