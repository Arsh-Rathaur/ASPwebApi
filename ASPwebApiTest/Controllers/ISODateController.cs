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
    public class ISODateController : ApiController
    {
        //GET : api/ISODate
        public ReturnValue<string>  Get()
        {
            ReturnValue<string> value = new ReturnValue<string>();
            try
            {
                value.Message = "Date in ISO8601 format";
                value.Value = DateTime.UtcNow.ToString("o");
                return value;
            }
            catch (Exception ex)
            {
                value.Message = ex.Message;
                value.Value = null;
                return value;
            }
           
        }
    }
}
