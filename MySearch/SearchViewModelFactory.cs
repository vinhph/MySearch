using MySearch.Models;

namespace MySearch
{
    public class SearchViewModelFactory
    {
        private readonly ISearchService _searchService;
        public SearchViewModelFactory(ISearchService searchService)
        {
            _searchService = searchService;
        }
        public SearchViewModel<T> Create<T>(T currentContent, FilterOptionViewModel viewModel) where T : IContent
        {
            var customSearchResult = _searchService.Search(currentContent, viewModel);
            return new SearchViewModel<T>
            {
                ProductViewModels = customSearchResult.ProductViewModels                
            };
        }
    }
}
