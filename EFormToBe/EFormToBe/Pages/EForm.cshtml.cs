using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFormToBe.Pages
{
    public class EFormModel : PageModel
    {

        public void OnGet()
        {
            var empType = HttpContext.Request.Query["empType"].ToString();
          
            if(empType == "PartTime")
            {
                ViewData["html"] = "Email: <input type=\"email\" id=\"email\" name=\"email\" /> <br/> <br/> <br/> Password: <input type=\"password\" id=\"pass\" name=\"pass\" /> <br/> <br/> <br/>";
            }
            else
            {
                ViewData["SavedDetails"] = HttpContext.Request.Query["handler"].ToString();
            }

        }
        public RedirectToPageResult OnPostSubmit(IFormCollection form)
        {
            string fName = form["FirstName"];
            string mName = form["MiddleName"];
            string lName = form["LastName"];
            string email = form["email"];

            var SavedDetails= "<br/>Full Name = " + fName + " " + mName + " " + lName+"<br/> Email :: "+email+"<br/>";

            return RedirectToPage("EForm",SavedDetails);
        }

      
    }

   
}
