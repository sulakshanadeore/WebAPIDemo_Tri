using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ProductsBusiness
    {

        public List<BusinessProd> ShowList() 
        {
         List<BusinessProd> blist=new List<BusinessProd>();
            ProductDAL dal = new ProductDAL();
            blist=dal.PopulateList();
            return blist;
        }

    }
}
