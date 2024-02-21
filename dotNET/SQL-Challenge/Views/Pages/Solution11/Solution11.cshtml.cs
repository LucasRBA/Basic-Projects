using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Views.Pages.Solution11
{
    public class Solution11 : PageModel
    {
        private readonly ILogger<Solution11> _logger;

        public Solution11(ILogger<Solution11> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}