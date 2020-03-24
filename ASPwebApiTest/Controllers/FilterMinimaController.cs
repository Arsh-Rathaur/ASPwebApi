using ASPwebApiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ASPwebApiTest.Controllers
{
    public class FilterMinimaController : ApiController
    {
        static HttpClient client = new HttpClient();

        

        public async Task<ReturnValue<List<Posts>>> Get()
        {
            ReturnValue<List<Posts>> value = new ReturnValue<List<Posts>>();

            string Path = "https://jsonplaceholder.typicode.com/posts";
            List<Posts> AllPosts = new List<Posts>();

            List<ProductsModel> productsModels = new List<ProductsModel>();

            try
            {
                HttpResponseMessage response = await client.GetAsync(Path);
                if (response.IsSuccessStatusCode)
                {
                    AllPosts = await response.Content.ReadAsAsync<List<Posts>>();
                    AllPosts = AllPosts.Where(x => x.body.Contains("minima")).OrderBy(x => x.id).ToList();
                }

                value.Message = "Data Fetched Successfully";
                value.Value = AllPosts;
            }
            catch (Exception ex)
            {
                value.Message = ex.Message;
                value.Value = AllPosts;
            }

            return value;

        }


    }
}
