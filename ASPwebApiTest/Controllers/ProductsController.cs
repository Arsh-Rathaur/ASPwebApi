using ASPwebApiTest.Models;
using BLL;
using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPwebApiTest.Controllers
{
    public class ProductsController : ApiController
    {
        public ProductsOperationsBLL Products;

        public ProductsController()
        {
            this.Products = new ProductsOperationsBLL();
        }

        // GET api/products
        public List<ProductsModel> Get()
        {
            List<ProductsModel> productsModels = new List<ProductsModel>();
            var JProducts = Products.GetAllProducts();
            foreach (var data in JProducts)
            {
                productsModels.Add(new ProductsModel
                {
                    ID = data.ID,
                    product_id = data.product_id,
                    product_name = data.product_name
                });
            }
            return productsModels;

        }

    }
}
