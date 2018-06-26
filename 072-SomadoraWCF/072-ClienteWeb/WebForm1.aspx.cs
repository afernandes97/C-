using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _072_ClienteWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var p = new ProxySomadora.SomadoraClient())
            {
                var r = new Random();
                Resultado.Text = p.Somar(r.Next(1, 101), r.Next(1, 101)).ToString();
            }
        }
    }
}