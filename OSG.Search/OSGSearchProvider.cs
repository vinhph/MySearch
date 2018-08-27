using EPiServer.Search;

namespace OSG.Search
{
    public class OsgSearchProvider : SearchProvider
    {
        public override ISearchResults Search(string applicationName, ISearchCriteria criteria)
        {
            var osgSearchResults = new OSGSearchResult("ResultDataExample");
            return (ISearchResults)osgSearchResults;
        }
    }
}
