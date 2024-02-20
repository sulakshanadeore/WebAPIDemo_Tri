using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductsDAL
    {
        public List<Product> PopulateList()
        {
            SqlConnection cn = new SqlConnection("server=.\\sqlexpress;database=Northwind;Integrated Security=true");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from products", cn);
            SqlDataReader dr=cmd.ExecuteReader();
            List<Product> list = new List<Product>();
            while (dr.Read())
            {
                Product p=new Product();
                p.Prodid = Convert.ToInt32(dr["ProductID"]);
                p.Prodname = dr["ProductName"].ToString();
                list.Add(p);
            }
            //Connection etc--Model/dbfist/ado.netconnected disconnected
           
            return list;



        }


    }

    public class Products
    {
    }
}
