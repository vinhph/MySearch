using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch.Models
{
    public class CatalogEntrySearchCriteria : ISearchCriteria
    {
        public virtual string CatalogName { get; set; }
    }
}
