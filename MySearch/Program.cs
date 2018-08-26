using MySearch.Models;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(_ =>
            {
                _.Scan(x =>
                {
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                });
            });
            var fashionNode = new FashionNode() { Id = 2 };
            var filterOptionViewModel = new FilterOptionViewModel() { FitlerTitle = "a" };
            var searchFacade = new SearchFacade();
            var mySearchService = new SearchService(searchFacade);
            SearchViewModelFactory viewModelFactory = new SearchViewModelFactory(mySearchService);
            var results = new CategoryController(viewModelFactory).Index(fashionNode, filterOptionViewModel);
            Console.Write(results?.ProductViewModels?.FirstOrDefault()?.Title);
            Console.ReadLine();

        }
    }
}
