﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch.Models
{
    public class SearchViewModel<T> where T : IContent
    {
        public IEnumerable<ProductTileViewModel> ProductViewModels { get; set; }
    }
}
