using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using web_app.Models;

namespace web_app.Controllers
{
    [Route("[controller]/[action]")]

    //[Route("Product")]
    public class ProductController : Controller
    {
        public  ProductRepository Repository =new();

        public bool CheckCode (int code)
        {
            if (code>9999 || code <1000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       
        //[Route("listmahsole")]
        public IActionResult Index(int brands)
        {
            var brandsList = Enum.GetValues(typeof(Brand)).Cast<Brand>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList();
            ViewBag.Brands = brandsList;

            var result = Repository.GeList();
            //return View(result);
            if (brands != 0)
            {
                return View(result.Where(x => (int)x.Brand ==brands ).ToList());
            }

            return View(result);
        }   

        //[Route("/sakhtmahsole")]

        public IActionResult Create()
        {

            var result = Enum.GetValues(typeof(Brand)).Cast<Brand>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList();
            ViewBag.Brands = result;

            var result2 = Enum.GetValues(typeof(Feature)).Cast<Feature>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList();
            ViewBag.Feature = result2;

            return View();
        }


        [HttpPost]
        public IActionResult Create(CreateViewModel product, List<int> feature, bool isAvailable)
        {
            Product newProduct = new();
            newProduct.Name = product.Name;
            newProduct.Model=product.Model;
            newProduct.Color= product.Color;
            newProduct.Brand= product.Brand;
            newProduct.Code= product.Code;
            newProduct.IsAvailable = isAvailable;
            foreach (var item in feature)
            {
                newProduct.Feature.Add(((Feature)item).ToString());
            }
            Repository.CreateProduct(newProduct);
            return RedirectToAction("Index");
        }
    }
}
