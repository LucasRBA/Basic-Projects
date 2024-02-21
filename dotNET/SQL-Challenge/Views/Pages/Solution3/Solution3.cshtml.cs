using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Views.Pages.Solution3
{
    public class Solution3 : PageModel
    {
        private readonly ILogger<Solution3> _logger;

        public Solution3(ILogger<Solution3> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}