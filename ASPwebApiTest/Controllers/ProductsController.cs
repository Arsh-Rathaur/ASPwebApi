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
        public ReturnValue<List<ProductsModel>> Get()
        {
            ReturnValue<List<ProductsModel>> value = new ReturnValue<List<ProductsModel>>();

            List<ProductsModel> productsModels = new List<ProductsModel>();

            try
            {
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
                value.Message = "Data Fetched Successfully";
                value.Value = productsModels;
            }
            catch (Exception ex)
            {
                value.Message = ex.Message;
                value.Value = productsModels;
            }

            return value;

        }

        // POST api/products
        public ReturnValue<bool> Post([FromBody]Products Values)
        {
            

            ReturnValue<bool> value = new ReturnValue<bool>();

            List<ProductsModel> productsModels = new List<ProductsModel>();

            try
            {
                var product = Products.GetAllProducts().Where(x => x.ID == Values.ID).FirstOrDefault();

                if (Convert.ToInt32(product.stock_available) >= Convert.ToInt32(Values.stock_available))
                {
                    value.Message = "Order Can Be Fulfilled";
                    value.Value = true;
                }
                else
                {
                    value.Message = "Order Cannot Be Fulfilled";
                    value.Value = false;
                }
               
            }
            catch (Exception ex)
            {
                value.Message = ex.Message;
                value.Value = false;
            }

            return value;

        }
    }
}
