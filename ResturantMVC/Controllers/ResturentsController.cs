using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ResturantMVC.Interface;
using ResturantMVC.Models;
using ResturantMVC.ViewModel;

namespace ResturantMVC.Controllers
{
    public class ResturentsController : Controller
    {
        private readonly IResturentService _resturent;
        private readonly IHtmlHelper _htmlHelper;

        public ResturentsController(IResturentService resturent,  IHtmlHelper htmlHelper)
        {
            _resturent = resturent;
            _htmlHelper = htmlHelper;
        }
        public IActionResult Index()
        {
            var model = _resturent.GetByName();
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var model = _resturent.GetById(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new Resturent();
            var viewModel = new ResturentViewModel
            { 
                
                Cusines = _htmlHelper.GetEnumSelectList<CusineType>(),
                Resturent = model,

            };
            
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(Resturent resturent)
        {
            if (ModelState.IsValid)
            {
                _resturent.Create(resturent);
                _resturent.Commit();

                return RedirectToAction("Index");
            }

            return View(resturent);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _resturent.GetById(id);
            var viewModel = new ResturentViewModel
            {
                Resturent = model,
                Cusines = _htmlHelper.GetEnumSelectList<CusineType>(),
            };

            return View(viewModel);

        }

        [HttpPost]
        public IActionResult Edit(Resturent resturent, int id)
        {
        
            var updateToResturent = _resturent.GetById(id);
           
            //if (updateToResturent == null) {
               
                
            //    return NotFound();
            
            //}

           
                updateToResturent.Name = resturent.Name;
                updateToResturent.Cusine = resturent.Cusine;
                updateToResturent.Location = resturent.Location;

                _resturent.Commit();

             return   RedirectToAction("Index");
            

         

        }

    }
}
