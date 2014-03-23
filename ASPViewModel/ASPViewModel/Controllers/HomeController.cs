using ASPViewModel.Models;
using ASPViewModel.Repositories;
using ASPViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPViewModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("AddProduct");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// to generate view with categories for entering product data
        /// </summary>
        [HttpGet]
        public ActionResult AddProduct()
        {
            //instantiate the product repository
            var productRepository = new ProductRepository();

            //for get product categories from database
            var prodcutCategories = productRepository.GetAllProductCategories();

            //for initialize viewmodel
            var productViewModel = new ProductViewModel();

            //assign values for viewmodel
            productViewModel.ProductCategories = prodcutCategories;

            //send viewmodel into UI (View)
            return View("AddProduct", productViewModel);
        }

        /// <summary>
        /// to save entered data 
        /// </summary>
        [HttpPost]
        public ActionResult AddProduct(ProductViewModel productViewModel) //save entered data
        {
            //instantiate the product repository
            var productRepository = new ProductRepository();

            //get product category for selected drop down list value
            var prodcutCategory = productRepository.GetProductCategory(productViewModel.SelectedValue);

            //for get all product categories
            var prodcutCategories = productRepository.GetAllProductCategories();

            //for fill the drop down list when validation fails 
            productViewModel.ProductCategories = prodcutCategories;

            //for initialize Product domain model
            var productObj = new Product
            {
                ProductName = productViewModel.ProductName,
                ProductCategory = prodcutCategory,
            };

            if (ModelState.IsValid) //check for any validation errors
            {
                //code to save valid data into database
                
                return RedirectToAction("AddProduct");
            }
            else
            {
                //when validation failed return viewmodel back to UI (View) 
                return View(productViewModel);
            }
        }

    }
}