using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFormAsIs
{
    public partial class EForm : System.Web.UI.Page
    {
        string empType = "";
        protected void Page_Load(object sender, EventArgs e)
        {
           empType= this.Request.Params["empType"];

            if (empType== "PartTime")
            {
                displayIfPartTime.InnerHtml = "Email: <input type=\"email\" id=\"email\" name=\"email\" /> <br/> <br/> <br/> Password: <input type=\"password\" id=\"pass\" name=\"pass\" /> <br/> <br/> <br/>";
            }
            else
            {

            }
        }
    }
}