using MySearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch
{
    public class CategoryController
    {
        private readonly SearchViewModelFactory _viewModelFactory;
        public CategoryController(
            SearchViewModelFactory viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }
        public SearchViewModel<FashionNode> Index(FashionNode currentContent, FilterOptionViewModel viewModel)
        {
            var model = _viewModelFactory.Create(currentContent, viewModel);
            return model;
        }
    }
}
