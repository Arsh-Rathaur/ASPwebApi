using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPwebApiTest.Models
{
    public class ReturnValue<T>
    {
        public string Message { get; set; }
        public T Value { get; set; }
    }
}