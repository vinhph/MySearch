namespace EPiServer.Search
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
