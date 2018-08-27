using EPiServer.Search;

namespace OSG.Search
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
