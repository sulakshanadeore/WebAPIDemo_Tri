using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;
using BusinessLogicLayer;
namespace WebAPIDemo.Controllers
{
    public class ProductsController : ApiController
    {

        public List<Products> GetProductsFromBusinessLayer() 
        { 
         List<Products> list=new List<Products>();
            ProductsBusiness bus = new ProductsBusiness();
           List<BusinessProd> busProducts= bus.ShowList();
            foreach (BusinessProd prod in busProducts) {

                list.Add(new Products { Prodid = prod.Prodid, ProductName = prod.ProductName });
            }
            return list;
        
        
        }

    }
}
