using System.Configuration.Provider;

namespace EPiServer.Search
{
    public abstract class SearchProvider : ProviderBase
    {
        public abstract ISearchResults Search(string applicationName, ISearchCriteria criteria);
    }
}
