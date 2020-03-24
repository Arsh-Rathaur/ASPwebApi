using DLL;
using DLL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductsOperationsBLL
    {
        IProductsOperations IProd;

        public ProductsOperationsBLL()
        {
            IProd = new ProductsOperationsDLL();
        }

        public List<Products> GetAllProducts()
        {
            return this.IProd.GetAllProducts();
        }

    }
}
