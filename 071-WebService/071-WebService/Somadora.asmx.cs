using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _071_WebService
{
    /// <summary>
    /// Summary description for Somadora
    /// </summary>
    [WebService(Namespace = "http://openlms.com.br")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Somadora : System.Web.Services.WebService
    {
        [WebMethod]
        public int Somar(int x, int y)
        {
            return x + y;
        }
    }
}
