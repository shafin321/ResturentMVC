using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantMVC.Models
{
   

    public enum CusineType
    {
        None,
        Italian,
        Maxican,
        French,
        Thai,
        Indian

    }

    public class Resturent 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CusineType Cusine { get; set; }
    }
}
