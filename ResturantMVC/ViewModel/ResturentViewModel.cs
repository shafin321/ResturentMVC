using Microsoft.AspNetCore.Mvc.Rendering;
using ResturantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantMVC.ViewModel
{
    public class ResturentViewModel
    {
        public Resturent Resturent { get; set; }
        public IEnumerable<SelectListItem> Cusines { get; set; }
    }
}
