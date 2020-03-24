using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DLL.HelperClasses
{
    public abstract class SQLBase
    {
        public SQLBase()
        {
        }
        /// <summary>
        /// Get the connection string from web.config file
        /// </summary>
        /// <returns>string type value of connection string</returns>
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DbProducts"].ConnectionString;
        }
    }
}
