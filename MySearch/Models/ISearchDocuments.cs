using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch.Models
{
    public interface ISearchDocuments : IList<ISearchDocument>, ICollection<ISearchDocument>, IEnumerable<ISearchDocument>, IEnumerable
    {
        int TotalCount { get; set; }
    }
}
