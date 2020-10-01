using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //protected void Page_PreRender(object sender, EventArgs e)
        //{
        //    Response.Write(DateTime.Now.ToString()+ "Page_PreRender");
        //}
        //protected void Page_OnInit(object sender, EventArgs e)
        //{
        //    Response.Write(DateTime.Now.ToString() + "Page_OnInit");
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(DateTime.Now.ToString() + "Page_Load");
            Response.Write(HttpContext.Current.ToString());

            Output.Text += "test" + Server.UrlEncode("http://google.com");
            //trigger changes in branch
        }
    }
}