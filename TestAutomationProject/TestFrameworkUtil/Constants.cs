using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkUtil
{
    public class Constants
    {
        public static string APP_URL = ConfigurationManager.AppSettings["APP_URL"];
        public static string ENV = ConfigurationManager.AppSettings["ENV"];
        public static string BROWSER = ConfigurationManager.AppSettings["BROWSER"];
    }
}
