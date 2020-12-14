using ResturantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantMVC.ViewModel
{
    public class ListSearchViewModel
    {
        public IEnumerable<Resturent> Resturents { get; set; }
        public string SearchTearm { get; set; }
    }
}
