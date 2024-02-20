using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class ProductsBusiness
    {

        public List<BusinessProd> ShowList() 
        {

         List<BusinessProd> blist=new List<BusinessProd>();
            ProductsDAL dal = new ProductsDAL();
            List<DataAccessLayer.Product> pDal = new List<DataAccessLayer.Product>();
            pDal=dal.PopulateList();
            foreach (var item in pDal)
            {
                BusinessProd productsBusiness = new BusinessProd();
                productsBusiness.Prodid=item.Prodid;
                productsBusiness.ProductName = item.Prodname;
                blist.Add(productsBusiness);
            }
            return blist;
        }

    }
}
