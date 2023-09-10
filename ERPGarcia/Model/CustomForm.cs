using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ERPGarcia.Model
{
    public class CustomForm : Form
    {
        NameValueCollection appSettings = ConfigurationManager.AppSettings;
        public CustomForm()
        {
            this.Text = appSettings["Title"];
        }
    }
}