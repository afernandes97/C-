using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _065_EDM
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DBEntities();

            var pessoas = db.PessoaSet;

            foreach (var item in pessoas)
            {
                Response.Write("<p>Id.....: " + item.Id + "<br/>");
                Response.Write("Nome...: " + item.Nome + "<br/>");
                Response.Write("Fumante: " + item.Fumante + "</p>");
                Response.Write("<hr/>");
            }
        }
    }
}