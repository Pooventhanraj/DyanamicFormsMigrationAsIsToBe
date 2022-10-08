using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFormToBe.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //public void OnGet(string name)
        //{
        //    ViewData["name"] = name;
        //}
        public void OnGet()
        {
            ViewData["name"] = HttpContext.Request.Query["empType"].ToString();
        }
        public void OnPostPostedData(string name)
        {
            ViewData["name"] = name;


        }
    }
}