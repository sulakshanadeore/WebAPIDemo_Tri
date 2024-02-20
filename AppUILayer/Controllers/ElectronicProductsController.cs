using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppUILayer.Controllers
{
    public class ElectronicProductsController : Controller
    {
        // GET: ElectronicProducts
        public ActionResult Index()
        {
            //Url: https:\\localhost:45336\Products\GetProductsFromBusinessLayer
            return View();
        }
    }
}