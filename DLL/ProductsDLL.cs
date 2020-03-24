using DLL.HelperClasses;
using DLL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class ProductsOperationsDLL : SQLBase, IProductsOperations
    {
        #region Ctor
        public ProductsOperationsDLL() : base(){
        }

        #endregion

        public List<Products> GetAllProducts()
        {
            List<Products> AllProducts = new List<Products>();

            using (ADOExecution exec = new ADOExecution(SQLBase.GetConnectionString()))
            {
                using (IDataReader dr = exec.ExecuteReader(CommandType.StoredProcedure, "GetAllProducts"))
                    while (dr.Read())
                    {
                        var Products = new Products();
                        Products.ID = Convert.ToInt32(dr["ID"]);
                        Products.product_id = (Convert.ToString(dr["product_id"]));
                        Products.product_name = Convert.ToString(dr["product_name"]);
                        Products.stock_available = Convert.ToString(dr["stock_available"]);
                        AllProducts.Add(Products);
                    }
                return AllProducts;
            }
        }
    }
}
