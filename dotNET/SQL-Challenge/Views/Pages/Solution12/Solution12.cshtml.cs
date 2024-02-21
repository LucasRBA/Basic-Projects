using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Views.Pages.Solution12
{
    public class Solution12 : PageModel
    {
        private readonly ILogger<Solution12> _logger;

        public Solution12(ILogger<Solution12> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}