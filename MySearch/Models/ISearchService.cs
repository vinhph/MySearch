﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch.Models
{
    public interface ISearchService
    {
        CustomSearchResult Search(IContent currentContent, FilterOptionViewModel filterOptions);
    }
}
