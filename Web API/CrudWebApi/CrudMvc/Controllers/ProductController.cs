using CrudMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CrudMvc.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            IEnumerable<MVCProductModel> prodList;
            HttpResponseMessage response = ProductWebClient.WebApiClient.GetAsync("Product").Result;
            prodList = response.Content.ReadAsAsync<IEnumerable<MVCProductModel>>().Result;
            return View();
        }
    }
}