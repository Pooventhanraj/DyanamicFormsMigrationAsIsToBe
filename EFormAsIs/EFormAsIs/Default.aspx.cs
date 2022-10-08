using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFormAsIs
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("EForm.aspx?empType=" + "FullTime");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EForm.aspx?empType=" + "PartTime");
        }
    }
}