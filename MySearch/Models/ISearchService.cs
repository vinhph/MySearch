
using EPiServer.Search;

namespace MySearch.Models
{
    public interface ISearchService
    {
        CustomSearchResult Search(IContent currentContent, FilterOptionViewModel filterOptions);
    }
}
