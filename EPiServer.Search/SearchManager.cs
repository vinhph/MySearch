namespace EPiServer.Search
{
    public class SearchManager
    {
        private readonly string _applicationName;
        public SearchManager(string applicationName)
        {
            _applicationName = applicationName;
        }
        public ISearchResults Search(ISearchCriteria criteria)
        {
            return SearchService.Search(this._applicationName, criteria);
        }
    }
}
