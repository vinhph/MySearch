using System.Configuration;
using System.Web.Configuration;

namespace EPiServer.Search
{
    internal class SearchService
    {
        private static SearchProvider _provider;
        public static SearchProvider Provider
        {
            get => _provider ?? (_provider = InitializeConfiguredProvider());
            set => _provider = value;
        }
        private static SearchProvider InitializeConfiguredProvider()
        {
            ProviderSettings providerSettings = new ProviderSettings()
            {
                Name = "OSG.Search",
                Type = "OSG.Search.OSGSearchProvider, OSG.Search"
            };
            SearchProvider searchProvider = (SearchProvider)ProvidersHelper.InstantiateProvider(providerSettings, typeof(SearchProvider));
            return searchProvider;
        }
        public static ISearchResults Search(string applicationName, ISearchCriteria criteria)
        {
            return Provider.Search(applicationName, criteria);
        }
    }
}
