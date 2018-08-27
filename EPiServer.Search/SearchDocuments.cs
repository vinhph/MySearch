using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.Search
{
    public class SearchDocuments : List<ISearchDocument>, ISearchDocuments, IList<ISearchDocument>, ICollection<ISearchDocument>, IEnumerable<ISearchDocument>, IEnumerable
    {
        /// <summary>Gets or sets the total count.</summary>
        /// <value>The total count.</value>
        public virtual int TotalCount { get; set; }
    }
}
