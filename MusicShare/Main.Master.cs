using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicShare
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            form1.Action = Request.RawUrl;

            addHeaders();
        }

        private void addHeaders()
        {
            try
            {
                
                string meta = "<link href=\"" + ResolveUrl("~/css/default.css") + "\" rel=\"Stylesheet\" type=\"text/css\" />";
                meta += "<link rel=\"shortcut icon\" href=\"" + Page.ResolveUrl("~/images/logo.jpg") + "\" />";
                Literal cssLiteral2 = new Literal();
                cssLiteral2.Text = meta;
                Page.Header.Controls.Add(cssLiteral2);
                
                litLogo.Text = "<center> <img  alt=\"Jatt.fm Single Tracks\" src=\"" + Page.ResolveUrl("~/images/logo.jpg") + "\" /></center>";
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}