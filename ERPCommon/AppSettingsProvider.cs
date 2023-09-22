using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCommon
{
    public class AppSettingsProvider
    {
        public static NameValueCollection AppSettings = ConfigurationManager.AppSettings;
    }




}
