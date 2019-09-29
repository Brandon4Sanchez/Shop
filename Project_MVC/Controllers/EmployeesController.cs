using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_MVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Logica.Models.BindingModels.EmployeesCreateBindingModels model)
        {
            if (ModelState.IsValid)
            {
                int id = model.Id;
                string firsname = model.FirsName;
                string secondname = model.SecondName;

                var createViewModel = new Logica.Models.ViewModels.EmployeesCreateViewModel();
                createViewModel.Name = string.Format("{0} {1}", firsname, secondname);

                ViewBag.Name = createViewModel;
                ViewBag.Id = id;

                return View();
            }

            return View(model);
        }
    }
}