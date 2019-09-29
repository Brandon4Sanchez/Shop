using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_MVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            Logica.BL.Products products = new Logica.BL.Products();

            var listProducts = (from q in products.GetProducts()
                                select new Logica.Models.ViewModels.ProductsIndexViewModel
                                {
                                    Id = q.Id,
                                    Name = q.Name,
                                    Guid = q.Guid,
                                    Extension = q.Extension,
                                    CategoryId = q.CategoryId,
                                    Price = q.Price,
                                    ShippingCost = q.ShippingCost,
                                    Warranty = q.Warranty,
                                    Description = q.Description,
                                    Quantity = q.Quantity,
                                    StateId = q.StateId,
                                    CustomerId = q.CustomerId
                                }).ToList();

            return View(listProducts);
        }
    }
}